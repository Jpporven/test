using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.Video;

public class TutorialManager : MonoBehaviour
{
    [Header("Step Counts")]
    private int stepCount;


    [Header("Players")]
    //public GameObject PlayerUI;
    public GameObject playerTutorial;
    public GameObject playerMenu;

    [Header("Text")]
    public TMP_Text tutorialText;


    [Header("GameObjects")]
    public GameObject mainMenu;
    //public GameObject ControlModel;
    public GameObject tongs;
    public GameObject button;
    public GameObject metal;
    public GameObject metallicElements;
    public GameObject bunsenBurner;
    public GameObject Dial;
    public GameObject MovementObj;
    public GameObject LookedObj;
    public GameObject desk;
    public GameObject indicator;
    public GameObject room;
    public GameObject video;


    [Header("Spawner")]
    public GameObject playerSpawner;

    [Header("Bools")]
    public bool hasBeenPressed;
    public bool experimented;
    public bool delay;



    [Header("References")]
    public XRKnob dial;
    public GameStartMenu gameStartMenu;
    public TutorialRaycast ray;
    public MovementDetection movement;
    public VideoPlayer VideoPlayer;
   
        

    // Start is called before the first frame update
    void Start()
    {
        experimented = metal.GetComponent<ExperimentBool>().hasBeenExperimentedOn;
       // delay = false;
        stepCount = 0;
        indicator.SetActive(false);
        hasBeenPressed = false;
        mainMenu.SetActive(false);
       

    }
    public void Update()
    {
        print(stepCount);
    }
    public IEnumerator Tutorial()
    {
        if (stepCount == 0)
        {
            tutorialText.text = "Welcome to Lab Lockdown tutorial";
            yield return new WaitForSeconds(1.5f);
            stepCount++;
        }

        if(stepCount == 1)
        {
            tutorialText.text = "Use your head to look at the red panels";

            yield return new WaitUntil(() => ray.Step1Complete == true);
            if (ray.Step1Complete == true)
            {
                yield return new WaitForSeconds(0.5f);
                stepCount++;
            }

            
        }

        if (stepCount == 2)
        {
            MovementObj.SetActive(true);
            tutorialText.text = " Use your Left Stick to move to the circle";   
            indicator.SetActive(true);
            yield return new WaitUntil(() => movement.Step2Complete == true);
            if (movement.Step2Complete)
            {
                yield return new WaitForSeconds(1.5f);
                stepCount++;
            }
           
        }

        if (stepCount == 3)
        {
            button.SetActive(true);
            tutorialText.text = " Press the button with your hand";
            IndicatorManager.GenerateNextIndicator(0);
            yield return new WaitUntil(() => stepCount != 3);
        }
        if(stepCount == 4)
        {
            yield return new WaitUntil(() => stepCount != 4);
        }
        if (stepCount == 5)
        {
            yield return new WaitForSeconds(1f);
            tutorialText.text = "Grab the metal with the tongs in your hands";
            yield return new WaitUntil(() => stepCount != 5);
        }
        if (stepCount == 6)
        {
            yield return new WaitForSeconds(1);
            tutorialText.text = "Nice Job , now use the dial to turn on the bunsen burner";
            yield return new WaitUntil(() => dial.value == 1);
            DialMoved();
            
        }
        if (stepCount == 7)
        {
            yield return new WaitForSeconds(1);
            tutorialText.text = "Put the metal on top of the bunsen burner until it burns";
            IndicatorManager.GenerateNextIndicator(4);
            yield return new WaitUntil(() => metal.GetComponent<ExperimentBool>().hasBeenExperimentedOn == true);
            yield return new WaitForSeconds(2);
            BunsenBurner();
            
        }
        if (stepCount == 8)
        {
            tutorialText.text = "Congratulations , you have completed the Tutorial" + "Press the Tutorial button in the main if you want to repeat the tutorial " +
               "good luck! ";
            yield return new WaitForSeconds(5);
            stepCount++;
            yield return new WaitUntil(() => stepCount != 8);
        }
        if (stepCount == 9)
        {
            room.SetActive(false);
            playerTutorial.SetActive(false);
            playerMenu.SetActive(true);
            yield return new WaitForSeconds(2f);   
            video.SetActive(true);
            VideoPlayer.Play();
            yield return new WaitForSeconds(8f);
            mainMenu.SetActive(true);
            yield return new WaitWhile(() => stepCount == 9);
        }



    
    }

   

    public void ButtonPressed()// 3.2
    {
        if(hasBeenPressed == false)
        {
            stepCount++;
            tongs.SetActive(true);
            metallicElements.SetActive(true);
            bunsenBurner.SetActive(true);
            Dial.SetActive(true);
            hasBeenPressed = true;
            tutorialText.text = "Grab the tongs of the table with your right grip button";
            IndicatorManager.GenerateNextIndicator(1);
            
           
            return;
        }
        if(hasBeenPressed == true)
        {
            SceneManager.LoadScene(0);
        }
        
    }

    public void TongsGrabbed() //3.3
    {
        if (stepCount == 4)
        {
            
            IndicatorManager.GenerateNextIndicator(2);
            print("Tongs were grabbed!");
            stepCount++;
        }
        
    }

    public void MetalGrabbed() //3.4
    {
        if(stepCount == 5)
        {
            IndicatorManager.GenerateNextIndicator(3);
            print("Metal Was Grabbed");
            stepCount++;
        }
       
        

    }

    public void DialMoved()
    {
        if(stepCount == 6)
        {
            if (dial.value == 1)
            {
                stepCount++;

            }
        }
       
    }
    public void BunsenBurner()
    {
        if (metal.GetComponent<ExperimentBool>().hasBeenExperimentedOn == true)
        {
            indicator.SetActive(false);
            stepCount++;
            //  delay = false;
            //StartCoroutine(Delay());
            desk.SetActive(false); 
            metallicElements.SetActive(false);
            Destroy(metal);
            Destroy(tongs);
            tongs.SetActive(false);
            Dial.SetActive(false);
            bunsenBurner.SetActive(false);
            button.SetActive(true);
            MovementObj.SetActive(false);
            LookedObj.SetActive(false);
            
            
           
        }
    }


    // Two buttons that the player can pick
    public void Yes()
    {
        
        //delay = false;  
       // StartCoroutine(Delay());
        playerTutorial.SetActive(true);
        playerTutorial.transform.position = playerSpawner.transform.position;
        metallicElements.SetActive(false);
        tongs.SetActive(false);
        Dial.SetActive(false);
        bunsenBurner.SetActive(false);
        button.SetActive(false);
        MovementObj.SetActive(false);
        LookedObj.SetActive(false);
        desk.SetActive(false);
        indicator.SetActive(false);
        stepCount = 9;
        StartCoroutine(Tutorial());  


    }
    public void No()
    {
        
       // delay = false;  
       /// StartCoroutine(Delay());
        playerTutorial.transform.position = playerSpawner.transform.position;
        playerTutorial.transform.rotation = playerSpawner.transform.rotation;
        mainMenu.SetActive(false);
        metallicElements.SetActive(false);
        tongs.SetActive(false);
        Dial.SetActive(false);
        bunsenBurner.SetActive(false);
        button.SetActive(false);
        MovementObj.SetActive(false);
         StartCoroutine(Tutorial());
        
    }

 
    
}
