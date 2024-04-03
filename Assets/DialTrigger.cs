using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class DialTrigger : MonoBehaviour
{
    public XRKnob nob;
    bool dialTurned = false;

    public void DialTurned()
    {
        if (nob.value == 1 && !dialTurned)
        {
            IndicatorManager.GenerateNextIndicator(IndicatorManager.currentIndicator++);
            dialTurned = true;
        }
    }
}
