using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tongsTriggerAgain : MonoBehaviour
{
    public bool isComplete = false;

    public void TongsGrabbedAgain()
    {
        if (IndicatorManager.currentIndicator == 2)
        {
            IndicatorManager.GenerateNextIndicator(3);

            isComplete = false;
        }else if(IndicatorManager.currentIndicator == 4)
        {
            IndicatorManager.GenerateNextIndicator(5);
        }
    }
}
