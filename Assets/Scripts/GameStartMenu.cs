using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStartMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject gameTitle;
    public GameObject mainMenu;
    public GameObject options;
    public GameObject credits;

    [Header("Main Menu Buttons")]
    public Button startButton;
    public Button optionButton;
    public Button creditsButton;
    public Button quitButton;

    public List<Button> returnButtons;

    public Color fadeoutColor;
    public float fadeSpeed = 0.5f;
    public int time = 5;
    bool finished;
    public SpriteRenderer color;

  
    // Start is called before the first frame update
    void Start()
    {
       
        startButton.onClick.AddListener(StartGame);
        optionButton.onClick.AddListener(EnableOption);
        creditsButton.onClick.AddListener(EnableCredits);
        quitButton.onClick.AddListener(QuitGame);

        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableMainMenu);
        }
    }

    private void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        HideAll();
        SceneManager.LoadScene(1);
    }

    public void HideAll()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
        credits.SetActive(false);
    }

    public void EnableMainMenu()
    {
        gameTitle.SetActive(false);
        mainMenu.SetActive(true);
        options.SetActive(false);
        credits.SetActive(true);
    }
    public void EnableOption()
    {
        print("Settings Enabled");
        mainMenu.SetActive(false);
        options.SetActive(true);
        credits.SetActive(false);
    }
    public void EnableCredits()
    {
        SceneManager.LoadScene(4);

    }

   

   

}
