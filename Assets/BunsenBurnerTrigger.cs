using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunsenBurnerTrigger : MonoBehaviour
{
    bool collided = false;
    public int step;

    private void OnTriggerEnter(Collider collision)
    {
        if (!collided)
        {
            IndicatorManager.GenerateNextIndicator(step);
            collided = true;
        }
    }
}
