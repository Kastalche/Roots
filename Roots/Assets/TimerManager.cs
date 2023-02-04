using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public RootManagerScript RootManager;
    public float timeForRoots;
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

    }
}
