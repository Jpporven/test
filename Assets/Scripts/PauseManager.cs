using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public Timer timer;
    public float tempTime;
    public GameObject tempTransform;
    public GameObject player;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuSpawner;
    public bool paused;

    [Header("UI Pages")]
    public GameObject mainMenu;
    public GameObject settings;
   

    [Header("Main Menu Buttons")]
    public Button resumeButton;
    public Button settingsButton;
    public Button quitButton;

    public Scrollbar volumeSlider;
    public TMPro.TMP_Dropdown turnDropdown;
    public SetTurnTypeFromPlayerPref turnTypeFromPlayerPref;
    public List<Button> returnButtons;

    // Start is called before the first frame update
    public void ActivatePauseMenu()
    {
        resumeButton.onClick.AddListener(ResumeGame);
        foreach (var item in returnButtons)
        { 
            item.onClick.AddListener(EnableMainMenu);
        }
        StopCoroutine(timer.lessTimer());

        tempTransform.transform.position = player.transform.position;
        tempTransform.transform.rotation = player.transform.rotation;
        player.transform.SetPositionAndRotation(pauseMenuSpawner.transform.position, pauseMenuSpawner.transform.rotation);
        pauseMenuUI.SetActive(true);

    }

    public void EnableMainMenu()
    {
        settings.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        player.transform.SetPositionAndRotation(tempTransform.transform.position, tempTransform.transform.rotation);
        pauseMenuUI.SetActive(false);
        tempTransform.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);

    }
    
    public void Settings()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
        volumeSlider.onValueChanged.AddListener(SetGlobalVolume);
        turnDropdown.onValueChanged.AddListener(SetTurnPlayerPref);

        if (PlayerPrefs.HasKey("turn"))
            turnDropdown.SetValueWithoutNotify(PlayerPrefs.GetInt("turn"));

        volumeSlider.gameObject.SetActive(true);
        turnDropdown.gameObject.SetActive(true); 

    }
    
    public void Quit()
    {
        Application.Quit(); 
    }

    public void SetGlobalVolume(float value)
    {
        AudioListener.volume = value;
    }
    public void SetTurnPlayerPref(int value)
    {
        PlayerPrefs.SetInt("turn", value);
        turnTypeFromPlayerPref.ApplyPlayerPref();
    }
}
