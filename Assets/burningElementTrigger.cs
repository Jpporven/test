using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burningElementTrigger : MonoBehaviour
{
    bool inRange = false;

    public GameObject Lithium;

    public void Update()
    {
        if (Vector3.Distance(Lithium.transform.position, transform.position) < 2f && !inRange)
        {
            print("Im in range!");

            IndicatorManager.GenerateNextIndicator(IndicatorManager.currentIndicator++);

            inRange = !false;
        }
    }
}
