using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalTrigger : MonoBehaviour
{
    bool isGrabbed = false;
    public void MetalGrabbed()
    {
        if (!isGrabbed)
        {
            IndicatorManager.GenerateNextIndicator(IndicatorManager.currentIndicator++);
            isGrabbed = true;
        }
    }

}
