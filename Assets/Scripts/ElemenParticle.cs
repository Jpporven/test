using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Transformers;

public class ElemenParticle : MonoBehaviour
{
   
    public ParticleSystem flameTest;

    private void Start()
    {
       
        
        flameTest = GetComponent<ParticleSystem>();
        flameTest.Stop();
       
    }

   public void PlayParticle()
    {
        flameTest.Play();
    }
    public void StopParticle()
    {
        flameTest.Stop();
    }
}
