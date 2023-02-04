using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public RootManagerScript RootManager;
    public float timeForRoots;
    public float timerForGame;
    
    void gameTime()
    {
        Debug.Log(timerForGame);
        if (timerForGame > 1f)
        {
            timerForGame -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Game Over");
        }
    }
    void Tick()
    {
        if (timeForRoots > 0f)
        {
            timeForRoots -= Time.deltaTime;
            Debug.Log(timeForRoots);
        }
        else
        {
            RootManager.Draw();
            timeForRoots = 3f;
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
