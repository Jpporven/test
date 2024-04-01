using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingElement : MonoBehaviour
{
    public bool elementAttatched = false;
    public GameObject[] elements ;
    public ControllingParticles isOn;
    public ElemenParticle [] particle;

    private void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < 6; i++)
        {
            if (other.gameObject == elements[i].gameObject || isOn.isOn == false)
            {
                Debug.Log("Should Stop");
                
                
            }
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < 6; i++)
        {
            if (other.gameObject == elements[i].gameObject && isOn.isOn == true)
            {
                Debug.Log("Should work");
                particle[i].PlayParticle();
            }
            
        }

    }
}
