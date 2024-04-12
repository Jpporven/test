using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Deattaching : MonoBehaviour
{

    // Pause Menu //
    public Timer timer;
    public InputActionProperty deattachToggle;
    public InputActionProperty pauseMenuAction;
    public InputActionProperty notebook;

    public NotebookManager notebookManager;
    Tongs tongs;
    public GameObject tong;
    public GameObject pauseMenu;
    public bool isPaused;
    public void Awake()
    {
        
         tongs = tong.GetComponent<Tongs>();
       
        
    }
    public void Update()
    {
        
        int pauseValue = pauseMenuAction.action.ReadValue<int>();
        float noteValue = notebook.action.ReadValue<float>();
        float buttonvalue = deattachToggle.action.ReadValue<float>();
        
        
        //print(pauseValue);
        if (buttonvalue != 0)
        {
                tongs.enabled = false;
        }
        else
             tongs.enabled = true;


        
       
        
            
        
        if(noteValue == 1)
        {
            notebookManager.OpenNoteBook();
        }
      

        
    }

    
    
}
