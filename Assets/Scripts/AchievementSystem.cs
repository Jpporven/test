using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : MonoBehaviour
{
    //Variables for the AchievementSystem

    //Variables for speedrun achievement
    //public GameObject timerImage;
    public static bool timerAchievement = false;

    //Variables for Chlorine and Florine Achievement
    public static bool HiddenAchievement = false;
    //public GameObject hiddenImage;

    //Referencing the scirpts needed
    private PTManager PTManager;
    private Timer timerScript;
    private AtomManager atomManager;

    // Start is called before the first frame update
    /*
    void Start()
    {
        timerImage.SetActive(false);
        hiddenImage.SetActive(false);
    }
    */

    private void Update()
    {
        AchievementChecker();
    }

    public void AchievementChecker()
    {
        
        //Checking if the requirements for the Speedrun achievement has been met
        if (atomManager.currentElement == 17 && timerScript.time > 1200)
        {
            //hiddenImage.SetActive(true);
            HiddenAchievement = true;

            medalScript.medal2Speed = true;
        }
    }
}
