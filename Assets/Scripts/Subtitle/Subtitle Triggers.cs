using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtitleTriggers : MonoBehaviour
{
    public Timer timer;

    public bool flourineCheck = false;
    public bool chlorineCheck = false;
    public bool checkboth = false;
    public bool quickClearCheck = true;

    public bool missdentifiedOnceCheck = false;

    //Opening
    public Subtitles opening;
    public Subtitles lv1Enter;

    //Dialog Within level 1
    public Subtitles minLeft20Lv1;
    public Subtitles minLeft10Lv1;
    public Subtitles minLeft5Lv1;
    public Subtitles minLeft0Lv1;

    //Dialog with level 2
    public Subtitles minLeft20Lv2;
    public Subtitles minLeft10Lv2;
    public Subtitles minLeft5Lv2;
    public Subtitles minLeft0Lv2;

    //Level clears
    public Subtitles lv1Clear;
    public Subtitles lv2Clear;

    //Game clears
    public Subtitles normalClear;
    public Subtitles quickClear;
    public Subtitles normalClearHidden;
    public Subtitles quickClearHidden;

    //Finding elements
    public Subtitles findFlourine;
    public Subtitles findClorine;
    public Subtitles findBothHidden;

    //Identify hiddens
    public Subtitles flourineIdentified;
    public Subtitles chlorineIdenified;

    //Misidentify hiddens
    public Subtitles missdentified;

    //play voice over
    public SoundManager sound;

    //subtitles
    public SubtitleManager subs;

    void Update()
    {
        if(flourineCheck == true && chlorineCheck == true && checkboth == false) 
        {
            checkboth = true;
            FindObjectOfType<SubtitleManager>().StartText(findBothHidden);
            medalScript.medal1Hidden = true;
        }
    }

    public void OpeningText()
    {
        FindObjectOfType<SubtitleManager>().StartText(opening);

       // sound.PlaySound(0);
    }

    public void EnterLevel1lText()
    {
        //timer.enterLv1 = true;
        //FindObjectOfType<SubtitleManager>().StartText(lv1Enter);

        //subs.voiceoverCount = 10;
        //sound.PlaySound(subs.voiceoverCount);
       // sound.PlaySound(1);
    }

    public void Level1ClearText()
    {
        FindObjectOfType<SubtitleManager>().StartText(lv1Clear);
        timer.level1Clear = true;

        //sound.PlaySound(2);
    }

    public void Level2ClearText()
    {
        FindObjectOfType<SubtitleManager>().StartText(lv2Clear);

        //sound.PlaySound(3);
    }

    public void minLeft20Lv1Text()
    {
        //FindObjectOfType<SubtitleManager>().StartText(minLeft20Lv1);

        //sound.PlaySound(4);
    }

    public void minLeft10Lv1Text()
    {
        //FindObjectOfType<SubtitleManager>().StartText(minLeft10Lv1);

        sound.PlaySound(27);
    }

    public void minLeft5Lv1Text()
    {
        //FindObjectOfType<SubtitleManager>().StartText(minLeft5Lv1);

        //subs.voiceoverCount = 28;
        //sound.PlaySound(subs.voiceoverCount);
        sound.PlaySound(28);
    }

    public void minLeft0Lv1Text()
    {
        //FindObjectOfType<SubtitleManager>().StartText(minLeft0Lv1);

        //subs.voiceoverCount = 29;
        //sound.PlaySound(subs.voiceoverCount);
        sound.PlaySound(29);
    }

    public void minLeft20Lv2Text()
    {
        //FindObjectOfType<SubtitleManager>().StartText(minLeft20Lv2);
        //sound.PlaySound(8);
    }

    public void minLeft10Lv2Text()
    {
        //FindObjectOfType<SubtitleManager>().StartText(minLeft10Lv2);

        //subs.voiceoverCount = 27;
        //sound.PlaySound(subs.voiceoverCount);
        sound.PlaySound(27);
    }

    public void minLeft5Lv2Text()
    {
        //FindObjectOfType<SubtitleManager>().StartText(minLeft5Lv2);

        //subs.voiceoverCount = 28;
        //sound.PlaySound(subs.voiceoverCount);
        sound.PlaySound(28);
    }

    public void minLeft0Lv2Text()
    {
        //FindObjectOfType<SubtitleManager>().StartText(minLeft0Lv1);

        //subs.voiceoverCount = 29;
        //sound.PlaySound(subs.voiceoverCount);
        sound.PlaySound(29);
    }




    public void FlourineIdentifiedText()
    {
        flourineCheck = true;
        //FindObjectOfType<SubtitleManager>().StartText(flourineIdentified);
    }

    public void ChlorineIdenifiedText()
    {
        chlorineCheck = true;
        //FindObjectOfType<SubtitleManager>().StartText(chlorineIdenified);
    }

    public void missdentifiedText()
    {
        if (missdentifiedOnceCheck == false)
        {
            //FindObjectOfType<SubtitleManager>().StartText(missdentified);
            missdentifiedOnceCheck = true;
        }
    }

    public void EscapeText()
    {
        if(checkboth == true)
        {
            if (quickClearCheck == true)
            {
                FindObjectOfType<SubtitleManager>().StartText(quickClearHidden);
            }
            else
                FindObjectOfType<SubtitleManager>().StartText(normalClearHidden);
        }
        else
        {
            if (quickClearCheck == true)
            {
                FindObjectOfType<SubtitleManager>().StartText(quickClear);
            }
            else
                FindObjectOfType<SubtitleManager>().StartText(normalClear);
        }
  
    }

}
