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
    public GameObject about;

    [Header("Main Menu Buttons")]
    public Button startButton;
    public Button optionButton;
    public Button aboutButton;
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
        aboutButton.onClick.AddListener(EnableAbout);
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
        about.SetActive(false);
    }

    public void EnableMainMenu()
    {
        gameTitle.SetActive(true);
        mainMenu.SetActive(true);
        options.SetActive(true);
        about.SetActive(false);
    }
    public void EnableOption()
    {
        print("Settings Enabled");
        mainMenu.SetActive(false);
        options.SetActive(true);
        about.SetActive(false);
    }
    public void EnableAbout()
    {
        gameTitle.SetActive(false);
        mainMenu.SetActive(false);
        options.SetActive(false);
        about.SetActive(true);
        
    }

   

   

}
