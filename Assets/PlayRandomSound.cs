using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    public SoundManager sound;
    int randomNum;

    private void Update()
    {
        randomNum = Random.Range(0, sound.sounds.Length + 1);
    }
    // Start is called before the first frame update
    public void PlayRandomSound_OnPress()
    {
        sound.PlaySound(randomNum);
    }
}
