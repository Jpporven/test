using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NotebookManager : MonoBehaviour
{
    public GameObject notebook;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject textPage;
    public TMP_Text elementName;
    public TMP_Text description;
    public TMP_Text clue;

    public TMP_Text AchievementTextPage2;
    public TMP_Text achievementTitlePage2;

    public TMP_Text AchievementTextPage3;
    public TMP_Text achievementTitlePage3;



    public bool noteOpen = false;

    private void Start()
    {
        textPage.SetActive(false);
        elementName.text = "";
        description.text = "";
        clue.text = "";
        
    }
    public void OpenNoteBook()
    {
        if (noteOpen == false)
        {
            notebook.SetActive(true);
            noteOpen = true;
        }

       else
        {
            notebook.SetActive(false);
            noteOpen = false;
        }
    }

    ////public void CloseNoteBook()
    //{
    //    if (noteOpen == true)
    //    {
    //        notebook.SetActive(false);
    //    }
    //}


    public void TabPage1()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        page3.SetActive(false);
    }

    public void TabPage2()
    {
        page1.SetActive(false);
        page2.SetActive(true);
        page3.SetActive(false);
    }
    public void TabPage3()
    {
        page1.SetActive(false);
        page2.SetActive(false);
        page3.SetActive(true);
    }

    public void Aluminun()
    {
        textPage.SetActive(true);
        elementName.text = "Aluminum";
        description.text = "Silvery gray metal";
        clue.text = "this element is in group 3A metal which does not give a color when burned in a flame with atomic number 13.";
        
    }

    public void Lithium()
    {
        textPage.SetActive(true);
        elementName.text = "Lithium";
        description.text = "soft silvery-white metal";
        clue.text = "this is an alkali metal which burns red in a flame test with atomic number 3.";
    }
    public void Sodium()
    {
        textPage.SetActive(true);
        elementName.text = "Aluminum";
        description.text = "soft silvery-white metal";
        clue.text = "this is an alkali metal which burns yellow in a flame test with atomic number 11.";
    }
    public void Magnesium()
    {
        textPage.SetActive(true);
        elementName.text = "Magnesium";
        description.text = "shiny gray metal";
        clue.text = "this is an alkaline earth metal which burns bright white in a flame test with atomic vcv number 12.";
    }
    public void Potassium()
    {
        textPage.SetActive(true);
        elementName.text = "Potassium";
        description.text = "silvery white metal";
        clue.text = "this is an alkali metal which burns lilac in a flame test with atomic number 19.";
    }
    public void Calcium()
    {
        textPage.SetActive(true);
        elementName.text = "Calcium";
        description.text = "dull gray silver metal";
        clue.text = "this is an alkaline earth metal burns orange red in a flame test with atomic number 20.";
    }
    public void Nitrogen()
    {
        textPage.SetActive(true);
        elementName.text = "Nitrogen";
        description.text = "colorless, odorless gas";
        clue.text = "this element forms a colorless, odorless diatomic gas which extinguishes a lighted. It has atomic number 7";
    }
    public void Oxygen()
    {
        textPage.SetActive(true);
        elementName.text = "Oxygen";
        description.text = "colorless gas";
        clue.text = "this element forms a colorless, odorless diatomic gas which reignites a lighted splint .It has atomic number 8";
    }
    public void Phosphorus()
    {
        textPage.SetActive(true);
        elementName.text = "Phosphorus";
        description.text = "red solid";
        clue.text = "this element has symbol P and atomic number 15, most common form is a red solidused in match sticks.";
    }
    public void Sulfur()
    {
        textPage.SetActive(true);
        elementName.text = "Aluminum";
        description.text = "pale yellow solid";
        clue.text = "this element is a pale yellow solid that has the symbol S and atomic number 16, has the smell of rotten eggs.";
    }
    public void Chlorine()
    {
        textPage.SetActive(true);
        elementName.text = "Chlorine";
        description.text = "this is a yellow-green gas";
        clue.text = "this element is a halogen which exists as a yellow-green gas, has symbol Cl and atomic number 17, has a noxious odor so kept in fume hood";
    }
    public void Fluorine()
    {
        textPage.SetActive(true);
        elementName.text = "Fluorine";
        description.text = "pale yellow gas";
        clue.text = "this element is a halogen which exists as a pale-yellow diatomic gas with atomic number 9";
    }

    public void TutorialAchievement()
    {
        
        achievementTitlePage2.text = "Achievement : Tutorial";
        achievementTitlePage2.text = "Complete the tutorial of the game following the steps of the guided element";
                
    }

    public void FirstLevelAchievement()
    {
        achievementTitlePage2.text = "Achievement : Getting Oxygen Back";
        achievementTitlePage2.text = "Find the key and complete the first level";
    }

    public void MissingElements()
    {
        achievementTitlePage3.text = "Achievement : The Hidden Ones ";
        achievementTitlePage3.text = "Find out the two hidden elements that are around the map";
    }

    public void SpeedRun()
    {
        achievementTitlePage3.text = "Achievement : SpeedRun";
        achievementTitlePage3.text = "//";
    }
    public void CloseNotebook() {
        textPage.SetActive(false) ;
        elementName.text = "";
        description.text = "";
        clue.text = "";
        noteOpen = false;
        notebook.SetActive(false);
    }
}
