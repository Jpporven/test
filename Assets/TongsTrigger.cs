using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class TongsTrigger : MonoBehaviour
{

    bool isGrabbed = true;
    bool isComplete = false;
    public void TongsGrabbed()
    {
        if (isGrabbed) 
        {
            IndicatorManager.GenerateNextIndicator(IndicatorManager.currentIndicator++);

            isGrabbed = false;

        }
    }
}
