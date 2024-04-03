using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTrigger : MonoBehaviour
{
    bool inRange = false;

    public GameObject Player;

    public void Update()
    {

        if (Vector3.Distance(Player.transform.position, transform.position) < 1.8f && !inRange)
        {
            InRange();
        }
        //print(Vector3.Distance(Player.transform.position, transform.position));
    }

    public void InRange()
    {
        print("Im in range!");

        IndicatorManager.GenerateNextIndicator(IndicatorManager.currentIndicator++);
        
        inRange = true;

        Destroy(this);
    }

}
