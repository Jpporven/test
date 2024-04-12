using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFinal : MonoBehaviour
{
    public AudioClip final;
    public Timer time;
   public SoundManager soundManager;
    public void Start()
    {
        soundManager.PlaySound(0);
    }
    public void Update()
    {
        if(time.time < 300)
        {
            soundManager.sounds[1] = final;
            soundManager.PlaySound(1);
        }
    }
}
