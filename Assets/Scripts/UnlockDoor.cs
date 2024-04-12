using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public GameObject Door;
    public GameObject keyCollision;
    Rigidbody Rigidbody;
   
    // Start is called before the first frame update
    private void Awake()
    {
        Rigidbody = Door.GetComponent<Rigidbody>();
    }
    public void Start()
    {
        Rigidbody.isKinematic = true;
    }
    // Update is called once per frame

    public void Unlock()
    {
        //if (gameObject.tag == "Key")
        //{
        Rigidbody.isKinematic = false;
        keyCollision.GetComponent<BoxCollider>().enabled = false;   
        //}
    }
    
}
