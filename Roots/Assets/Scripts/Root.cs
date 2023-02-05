using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{
   // public AudioSource rootdestroy;
    public int clickCount;
    int clicks=0;
    public Sprite[] rootstates;
    // Start is called before the first frame update
    void OnMouseUpAsButton()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color == new Color32(120, 74, 72, 255)) 
        {
            clicks++;
            gameObject.GetComponent<SpriteRenderer>().sprite=rootstates[clicks];


            if (clicks == clickCount)
            {
              //  rootdestroy.Play();
                Destroy(gameObject);
                Debug.Log(gameObject);
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
