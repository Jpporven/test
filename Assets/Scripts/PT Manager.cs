using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTManager : MonoBehaviour
{
    //Notebook
    public UngreyElements ungreyElements;

    //Element Number, allows for identification of the inputted element.
    public int elementNum = 0;
    public int elementCount = 0;

    //Key and renderer of the key object.
    public GameObject key;
    public GameObject keyLooks;
    Renderer keyRend;

    //Win and bonus condition ints.
    public int winCondition = 10;
    public int achievementCondition = 12;

    //Booleans of the different elements.
    public bool activeAluminum = false; //1
    public bool activeCalcium = false; //2
    public bool activeLithium = false; //3
    public bool activeMagnesium = false; //4
    public bool activeSodium = false; //5
    public bool activePotassium = false; //6
    public bool activeNitrogen = false; //7
    public bool activeOxygen = false; //8
    public bool activeFluorine = false; //9
    public bool activePhosphorus = false; //10
    public bool activeSulfur = false; //11
    public bool activeChlorine = false; //12

    //Panels of the different elements.
    public GameObject panelAluminum;
    public GameObject panelCalcium;
    public GameObject panelLithium;
    public GameObject panelMagnesium;
    public GameObject panelSodium;
    public GameObject panelPotassium;
    public GameObject panelNitrogen;
    public GameObject panelOxygen;
    public GameObject panelFluorine;
    public GameObject panelPhosphorus;
    public GameObject panelSulfur;
    public GameObject panelChlorine;

    //Gets the renderer of the key at the start of the game to be able to change its color and sets it to false.
    private void Start()
    {
        //Deactivate key and get the renderer.
        key.SetActive(false);
        keyRend = keyLooks.GetComponent<Renderer>();

        //Deactivate the panels.
        panelAluminum.SetActive(false);
        panelCalcium.SetActive(false);
        panelLithium.SetActive(false);
        panelMagnesium.SetActive(false);
        panelSodium.SetActive(false);
        panelPotassium.SetActive(false);
        panelNitrogen.SetActive(false);
        panelOxygen.SetActive(false);
        panelFluorine.SetActive(false);
        panelPhosphorus.SetActive(false);
        panelSulfur.SetActive(false);
        panelChlorine.SetActive(false);
    }

    /*************************************************************************************************
     * Gets the Element Number from the PT Interactions script, puts it inside of a switch statement *
     * and uses it to check witch of the elements have been put correctly inside the periodic table, *
     * after that increases the count of elements gotten right and checks if the win condition has   *
     * been met, also the if statement and boolean unables this to be repeated.                      *
     *************************************************************************************************/
    public void countNActivate(int i)
    {
        elementNum = i;

        switch (elementNum)
        {
            case 0:
                Debug.Log("Didn't assign anything.");
                break;

            case 1:
                if (activeAluminum == false)
                {
                    activeAluminum = true;
                    panelAluminum.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement1();
                }
                break;

            case 2:
                if (activeCalcium == false)
                {
                    activeCalcium = true;
                    panelCalcium.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement2();
                }
                break;

            case 3:
                if (activeLithium == false)
                {
                    activeLithium = true;
                    panelLithium.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement5();
                }
                break;

            case 4:
                if (activeMagnesium == false)
                {
                    activeMagnesium = true;
                    panelMagnesium.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement6();
                }
                break;

            case 5:
                if (activeSodium == false)
                {
                    activeSodium = true;
                    panelSodium.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement3();
                }
                break;

            case 6:
                if (activePotassium == false)
                {
                    activePotassium = true;
                    panelPotassium.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement4();
                }
                break;

            case 7:
                if (activeNitrogen == false)
                {
                    activeNitrogen = true;
                    panelNitrogen.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement7();
                }
                break;

            case 8:
                if (activeOxygen == false)
                {
                    activeOxygen = true;
                    panelOxygen.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement8();
                }
                break;

            case 9:
                if (activeFluorine == false)
                {
                    activeFluorine = true;
                    panelFluorine.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement12();   
                }
                break;

            case 10:
                if (activePhosphorus == false)
                {
                    activePhosphorus = true;
                    panelPhosphorus.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement9();
                }
                break;

            case 11:
                if (activeSulfur == false)
                {
                    activeSulfur = true;
                    panelSulfur.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement10();
                }
                break;

            case 12:
                if (activeChlorine == false)
                {
                    activeChlorine = true;
                    panelChlorine.SetActive(true);
                    elementCount++;
                    keyCheck();
                    ungreyElements.UngreyElement11();
                }
                break;
        }
    }

    //Checks for the win conditions.
    void keyCheck()
    {
        if (elementCount == winCondition) //Win Condition.
        {
            key.SetActive(true);
            keyRend.material.color = Color.yellow;
        }
        else if (elementCount == achievementCondition) //Achievement.
        {
            keyRend.material.color = Color.red;
        }
    }
}