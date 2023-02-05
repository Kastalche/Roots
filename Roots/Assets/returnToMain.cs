using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMain : MonoBehaviour
{
    public GameObject music;
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("StartGame");
        DontDestroyOnLoad(music);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
