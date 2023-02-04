using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{
    public int clickCount;
    int clicks=0;
    public Sprite[] rootstates;
    // Start is called before the first frame update
    void OnMouseUpAsButton()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color == Color.white) 
        {
            clicks++;
            gameObject.GetComponent<SpriteRenderer>().sprite=rootstates[clicks];


            if (clicks == clickCount)
                Destroy(gameObject);
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
