using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseMenuManager : MonoBehaviour
{
   public GameObject settings;
    public GameObject quit;
    public SetTurnTypeFromPlayerPref turnTypeFromPlayerPref;
    public GameObject SettingOptions;
    public Scrollbar volumeSlider;

    private void Start()
    {
        volumeSlider.onValueChanged.AddListener(volumeController);
    }
    public void enableMainMenu()
    {
        settings.SetActive(true);
        quit.SetActive(true);
        SettingOptions.SetActive(false);
    }

    public void Options()
    {
        settings.SetActive(false);
        quit.SetActive(false);
        SettingOptions.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
  
    public void Snap()
    {
        PlayerPrefs.SetInt("turn", 0);
        turnTypeFromPlayerPref.ApplyPlayerPref();
    }

    public void Continuous()
    {
        PlayerPrefs.SetInt("turn", 1);
        turnTypeFromPlayerPref.ApplyPlayerPref();
    }

    public void volumeController(float value )
    {
        
            AudioListener.volume = value;
        
    }
}
