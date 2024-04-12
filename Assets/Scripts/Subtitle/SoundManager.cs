using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(AudioSource))]

public class SoundManager : MonoBehaviour
{
    public AudioClip[] sounds;
    [SerializeField] private bool playOnCollision;
    [SerializeField] private string sfxType;
    private AudioSource soundOutput;

    void Awake()
    {
        soundOutput = GetComponent<AudioSource>();
    }
    
   /* void OnCollisionEnter(Collision other)
    {
        if(playOnCollision)
        {
            if(sfxType == "glass")
            {
                
            }else if(sfxType == "metal")
            {

            }else if(sfxType == "wood")
            {

            }else if(sfxType == "ball")
            {

            }
        }
    }
   */
    
    public void PlaySound(int soundNumber)
    {
        soundOutput.clip = sounds[soundNumber];
        soundOutput.Play();

        Debug.Log("We are playing the voice over");
    }

    
}
