using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookManager : MonoBehaviour
{
    public GameObject notebook;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;


    public bool noteOpen = false;

    public KeyCode notebookButton;


    void Update()
    {
        if (Input.GetKeyDown(notebookButton))
        {
            OpenCloseNote();
        }
    }

    public void OpenCloseNote()
    {
        if (noteOpen == false)
        {
            notebook.SetActive(true);
            noteOpen = true;
        }
        else if (noteOpen == true) 
        {
            notebook.SetActive(false);
            noteOpen = false;
        }

    }


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
}
