using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    public RootManagerScript RootManager;
    public float timeForRoots;
    public float timerForGame;
    public float timeForLooseGame;

    void gameTime()
    {
        // Debug.Log(timerForGame);
        if (RootManager.isFlying)
        {
            if (timerForGame < 1f)
            {
                SceneManager.LoadScene("WonGame");
            }
        }
        if (timerForGame > 1f)
        {
            timerForGame -= Time.deltaTime;
        }
        
        if(timeForLooseGame > 1f)
        {
            timeForLooseGame -= Time.deltaTime;
        }
        if (timeForLooseGame < 1f && RootManager.roots.Count > 3)
        {
            SceneManager.LoadScene("GameOver");
        }
    }   

    void Tick()
    {
        if (timeForRoots > 0f)
        {
            timeForRoots -= Time.deltaTime;
            //   Debug.Log(timeForRoots);
        }
        else
        {
            RootManager.Draw();
            timeForRoots = 1.5f;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Tick();
        gameTime();
    }

}