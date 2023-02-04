using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{
    public int clickCount;
    public int clicks=0;
    // Start is called before the first frame update
    void OnMouseUpAsButton()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color == new Color32(0, 0, 0, 255))
        {
            clicks++;
            if (clicks == clickCount)
            {
                
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
