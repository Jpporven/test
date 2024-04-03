using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongsManager : MonoBehaviour
{
    public Transform targetTransform; // Public transform to match with collided object
    public bool holdingElement = false;

    public void OnCollisionEnter(Collision collision)
    {
            collision.collider.enabled = false;
            // Match the collided object's transform with the targetTransform
            collision.transform.position = targetTransform.position;
            collision.transform.rotation = targetTransform.rotation;
            collision.transform.SetParent(targetTransform);

            holdingElement = true;
            print("This is working");
    }

}
