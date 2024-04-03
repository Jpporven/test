using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNextTriggerScript : MonoBehaviour
{
    [SerializeField] private DistanceTrigger dt;
    [SerializeField] private burningElementTrigger bet;


    // Start is called before the first frame update
    void Awake()
    {
        dt.enabled = false;
        bet.enabled = true;
    }

    
}
