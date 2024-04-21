using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubtitleManager : MonoBehaviour
{
    public SoundManager sound;
    //public GameObject offset;
    public Rigidbody door;
    public GameObject waitForDoorSign;
    //public GameObject player;

    public TMP_Text sentenceText;

    //public GameObject textPanel;

    public Queue<string> sentences;

    public float textTypeSpeed = 0.05f;
    public float sentencePause = 1f;
    public int voiceoverCount;

    public void Start()
    {
        sentences = new Queue<string>();
    }

    private void FixedUpdate()
    {
        //lockSubtitles();
    }

    public void StartText (Subtitles subtitle)
    {
        sentences.Clear();

        sound.PlaySound(voiceoverCount);

        foreach (string sentence in subtitle.sentences) 
        {
            sentences.Enqueue(sentence);
        }
        NextSentence();
    }

    public void NextSentence ()
    {
        if (sentences.Count == 0) 
        {
            EndSubtitle();
            return;
        }

        sound.PlaySound(voiceoverCount);
        voiceoverCount += 1;

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(Typer(sentence));

    }

     IEnumerator Typer(string sentence)
    {
        sentenceText.text = "";

        foreach (char letter in sentence.ToCharArray()) 
        {
            sentenceText.text += letter;
            //yield return null;
            yield return new WaitForSeconds(textTypeSpeed);
        }
        yield return new WaitForSeconds(sentencePause);
        print("Sentence End");
        if(voiceoverCount > 9)
        {
            door.isKinematic = false;
            waitForDoorSign.SetActive(false);
        }
        NextSentence();


    }

    void EndSubtitle()
    {
        sentenceText.text = "";
    }
     

    //public void lockSubtitles()
    //{
    //    if (textPanel.activeSelf == false)
    //    {
    //        return;
    //    }

    //    Vector3 textPanelPosition = Vector3.Lerp(textPanel.transform.position, offset.transform.position, 1f * Time.deltaTime);
    //    textPanel.transform.position = textPanelPosition;

    //    Quaternion Lookrotation = Quaternion.LookRotation(textPanel.transform.position - player.transform.position, Vector3.up);
    //    textPanel.transform.rotation = Lookrotation;
    //}

}
