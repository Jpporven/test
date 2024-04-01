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
    public PauseManager pauseManager;

    public Timer timer;
    public InputActionProperty deattachToggle;
    public InputActionProperty pauseMenuAction;
    public InputActionProperty notebook;

    public NotebookManager notebookManager;
    XRSocketInteractor socket;
    public GameObject  tong;
    public GameObject pauseMenu;
    public bool isPaused;
    public void Awake()
    {
        
         socket = tong.GetComponent<XRSocketInteractor>();
       
        
    }
    public void Update()
    {
        
        int pauseValue = pauseMenuAction.action.ReadValue<int>();
        float noteValue = notebook.action.ReadValue<float>();
        float buttonvalue = deattachToggle.action.ReadValue<float>();
        
        
        //print(pauseValue);
        if (buttonvalue != 0)
        {
                socket.enabled = false;
        }
        else
             socket.enabled = true;


        
        if (pauseValue != 0)
        {
            isPaused = true;
        }
        if (isPaused == true)
        {
            
           pauseManager.ActivatePauseMenu();
           pauseMenu.SetActive(true);
        }
        
            
        
        if(noteValue == 1)
        {
            notebookManager.OpenNoteBook();
        }
      

        
    }

    
    
}
