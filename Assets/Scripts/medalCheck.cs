using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class medalCheck : MonoBehaviour
{
    public Image medalImage1Hidden;
    public Image medalImage2Speed;

    public SoundManager sound;

    private void Update()
    {
        //Checks for the first achievement (Hidden elements)
        if (medalScript.medal1Hidden == false)
        {
            medalImage1Hidden.enabled = false;
        }
        else if (medalScript.medal1Hidden == true)
        {
            medalImage1Hidden.enabled = true;
        }

        //Checks for the second achievement (Complete in <10)
        if (medalScript.medal2Speed == false)
        {
            medalImage2Speed.enabled = false;
        }
        else if (medalScript.medal2Speed == true)
        {
            medalImage2Speed.enabled = true;
        }

        if(medalScript.medal2Speed == true && medalScript.medal2Speed == false)
        {
            sound.PlaySound(0);
        }
        else
        {
            sound.PlaySound(1);
        }
    }

    //****The rest is for testing only****//
    public void Medal1IsTrue()
    {
        medalScript.medal1Hidden = true;
    }

    public void Medal1IsFalse()
    {
        medalScript.medal1Hidden = false;
    }

    public void Medal2IsTrue()
    {
        medalScript.medal2Speed = true;
    }

    public void Medal2IsFalse()
    {
        medalScript.medal2Speed = false;
    }

    public void moveToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void moveToGame()
    {
        SceneManager.LoadScene(1);
    }
}
