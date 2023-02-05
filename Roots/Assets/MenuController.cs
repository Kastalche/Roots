using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public Image background;
    //public Image backgroundPlay;
    //public Image backgroundSettings;
    //public Image backgroundQuit;

    public Button buttonPlay;
    public Button buttonSettings;
    public Button buttonQuit;

    void Start()
    {
        buttonPlay.onClick.AddListener(buttonPlayClicked);
        buttonSettings.onClick.AddListener(buttonSettingsClicked);
        buttonQuit.onClick.AddListener(buttonQuitClicked);
    }

    void buttonPlayClicked() {
        SceneManager.LoadScene("NextScene");
        //background.sprite = backgroundPlay.sprite;
    }

    void buttonSettingsClicked() {
        SceneManager.LoadScene("SettingsScene");
        //background.sprite = backgroundSettings.sprite;
    }

    void buttonQuitClicked() {
        Application.Quit();
        //background.sprite = backgroundQuit.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
