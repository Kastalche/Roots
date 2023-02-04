using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuHover : MonoBehaviour
{
    void OnMouseOver()
    {
        //Animation
        //Debug.Log("Mouse is over GameObject.");
    }
    void OnMouseUpAsButton()
    {
        if (gameObject.name == "CapsulePlay")
        {
            StartGame();
        }
        else if (gameObject.name == "CapsuleSettings")
        {
            GoToSetting();
        }
        else if (gameObject.name == "CapsuleQuit")
            QuitAplication();
        //Animation
        //Debug.Log("Mouse is over GameObject.");
    }

    void Start()
    {

    }
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("Scene_3");
    }
    public void GoToSetting()
    {
        Debug.Log("Settings!");
    }
    public void QuitAplication()
    {
        Application.Quit();
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
