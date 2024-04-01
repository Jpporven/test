using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UngreyElements : MonoBehaviour
{
    public Button[] elements;
  


    //change name later according to element 
    private void Start()
    {
        elements[10].gameObject.SetActive(false);
        elements[11].gameObject.SetActive(false);
    }
    public void UngreyElement1()
    {
        elements[0].interactable = true;
    }

    public void UngreyElement2()
    {
        elements[1].interactable = true;
    }

    public void UngreyElement3()
    {
        elements[2].interactable = true;
    }
    public void UngreyElement4()
    {
        elements[3].interactable = true;
    }

    public void UngreyElement5()
    {
        elements[4].interactable = true;
    }

    public void UngreyElement6()
    {
        elements[5].interactable = true;
    }

    public void UngreyElement7()
    {
        elements[6].interactable = true;
    }

    public void UngreyElement8()
    {
        elements[7].interactable = true;
    }

    public void UngreyElement9()
    {
        elements[8].interactable = true;
    }

    public void UngreyElement10()
    {
        elements[9].interactable = true;
    }


    public void UngreyElement11()
    {
        elements[10].gameObject.SetActive(true);
    }

    public void UngreyElement12()
    {
        elements[11].gameObject.SetActive(true);
    }
}
