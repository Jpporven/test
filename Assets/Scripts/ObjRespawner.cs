/**************************************************************************
 * This script at the moment has the only purpose of respawning the tongs,*
 * and all the metals from the first lab whenever they fall on the floor  *
 **************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRespawner : MonoBehaviour
{
    //Objects to move and below it its respawn point.
    public GameObject tongs;
    public GameObject tongRespawner;

    public GameObject aluminum;
    public GameObject aluminumRespawner;

    public GameObject calcium;
    public GameObject calciumRespawner;

    public GameObject lithium;
    public GameObject lithiumRespawner;

    public GameObject potassium;
    public GameObject potassiumRespawner;

    public GameObject magnesium;
    public GameObject magnesiumRespawner;

    public GameObject sodium;
    public GameObject sodiumRespawner;


    //Rigidbody used to dump all the gameobjects rigidbodies.
    Rigidbody rb;

    //Boolean that activates the method for the Indicator Manager
    bool nextStep = false;

    //When something falls...
    private void OnTriggerEnter(Collider other)
    {

        //Check if the aluminum collides.
        if (other.gameObject == aluminum)
        {
            //Move them to the previously stated spawnpoint.
            aluminum.transform.position = aluminumRespawner.transform.position;
            //Rotates the tongs to keep them from falling upright.
            aluminum.transform.rotation = aluminumRespawner.transform.rotation;
            //Negates any force the object might have at the time of falling.
            rb = aluminum.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            Debug.Log("Aluminum respawned"); //We did it!
        }

        //Check if the calcium collides.
        if (other.gameObject == calcium)
        {
            //Move them to the previously stated spawnpoint.
            calcium.transform.position = calciumRespawner.transform.position;
            //Rotates the tongs to keep them from falling upright.
            calcium.transform.rotation = calciumRespawner.transform.rotation;
            //Negates any force the object might have at the time of falling.
            rb = calcium.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            Debug.Log("Calcium respawned"); //We did it!
        }

        //Check if the lithium collides.
        if (other.gameObject == lithium)
        {
            //Move them to the previously stated spawnpoint.
            lithium.transform.position = lithiumRespawner.transform.position;
            //Rotates the tongs to keep them from falling upright.
            lithium.transform.rotation = lithiumRespawner.transform.rotation;
            //Negates any force the object might have at the time of falling.
            rb = lithium.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            Debug.Log("Lithium respawned"); //We did it!
        }

        //Check if the potassium collides.
        if (other.gameObject == potassium)
        {
            //Move them to the previously stated spawnpoint.
            potassium.transform.position = potassiumRespawner.transform.position;
            //Rotates the tongs to keep them from falling upright.
            potassium.transform.rotation = potassiumRespawner.transform.rotation;
            //Negates any force the object might have at the time of falling.
            rb = potassium.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            Debug.Log("Potassium respawned"); //We did it!
        }

        //Check if the magnesium collides.
        if (other.gameObject == magnesium)
        {
            //Move them to the previously stated spawnpoint.
            magnesium.transform.position = magnesiumRespawner.transform.position;
            //Rotates the tongs to keep them from falling upright.
            magnesium.transform.rotation = magnesiumRespawner.transform.rotation;
            //Negates any force the object might have at the time of falling.
            rb = magnesium.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            Debug.Log("Magnesium respawned"); //We did it!
        }

        //Check if the sodium collides.
        if (other.gameObject == sodium)
        {
            //Move them to the previously stated spawnpoint.
            sodium.transform.position = sodiumRespawner.transform.position;
            //Rotates the tongs to keep them from falling upright.
            sodium.transform.rotation = sodiumRespawner.transform.rotation;
            //Negates any force the object might have at the time of falling.
            rb = sodium.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            Debug.Log("Sodium respawned"); //We did it!
        }

        //Check if the tongs collide.
        if (other.gameObject == tongs)
        {
            //Move them to the previously stated spawnpoint.
            tongs.transform.position = tongRespawner.transform.position;
            //Rotates the tongs to keep them from falling upright.
            tongs.transform.rotation = tongRespawner.transform.rotation;
            //Negates any force the object might have at the time of falling.
            rb = tongs.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            Debug.Log("Tongs respawned"); //We did it!
            
        }
    }
}
