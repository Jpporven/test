using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTrigger : MonoBehaviour
{
    bool inRange = false;

    public GameObject Player;

    public float range;

    public void Update()
    {

        if (Vector3.Distance(Player.transform.position, transform.position) < range && !inRange)
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
