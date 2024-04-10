using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongs : MonoBehaviour
{
    public int rayCount = 5; // Number of rays to shoot out
    public float raySpreadAngle = 10f; // Angle between each ray in degrees
    public float raycastDistance = 10f; // Public variable to specify the distance of the raycast
    public string targetTag; // Public variable to specify the tag we're looking for
    public Transform resetTransform;
    [SerializeField] private GameObject currentElement;

    void OnEnable()
    {
        StartCoroutine(ShootElementRays(true));
    }

    void OnDisable()
    {
        if(currentElement != null)
        {
            currentElement.transform.parent = null;

            currentElement.GetComponent<Rigidbody>().isKinematic = false;

            currentElement = null;
        }
        

        StopAllCoroutines();
    }


    IEnumerator ShootElementRays(bool loop)
    {
        
        while(loop)
        {
            yield return new WaitForSeconds(0.2f);

            float angleStep = raySpreadAngle / (rayCount - 1);

            for (int i = 0; i < rayCount; i++)
            {
                Vector3 rayDirection = Quaternion.Euler(0f, -raySpreadAngle / 2f + angleStep * i, 0f) * transform.forward;

                Debug.DrawRay(transform.position, rayDirection * raycastDistance, Color.red);


                // Cast a ray in the current direction
                RaycastHit hit;
                if (Physics.Raycast(transform.position, rayDirection, out hit, raycastDistance))
                {
                    // Draw the ray in the Scene view for debugging purposes
                    Debug.DrawRay(transform.position, rayDirection * raycastDistance, Color.green);

                    // Check if the object hit has the specified tag
                    if (hit.collider.gameObject.CompareTag(targetTag.ToString()) && currentElement == null)
                    {
                        // Get the Rigidbody component of the hit object
                        Rigidbody hitRigidbody = hit.collider.gameObject.GetComponent<Rigidbody>();

                        // If the hit object has a Rigidbody component
                        if (hitRigidbody != null)
                        {
                            // Set the Rigidbody to kinematic
                            hitRigidbody.isKinematic = true;
                        }

                        currentElement = hit.collider.gameObject;

                        // Set the hit object's parent to the script's GameObject
                        hit.collider.gameObject.transform.SetParent(transform);

                        // Reset the transform and position of the object to the specified transform
                        hit.collider.gameObject.transform.position = resetTransform.position;
                        hit.collider.gameObject.transform.rotation = resetTransform.rotation;

                        // You can add more logic here, like interacting with the object
                        Debug.Log("Raycast hit target: " + hit.collider.gameObject.name);

                        loop = false;
                    }
                }
                else
                {
                    // Draw the ray in the Scene view for debugging purposes
                    Debug.DrawRay(transform.position, rayDirection * raycastDistance, Color.red);
                }
            }
        }

        
    }
}
