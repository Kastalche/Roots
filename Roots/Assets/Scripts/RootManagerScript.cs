using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootManagerScript : MonoBehaviour
{
    public List<GameObject> roots;
    public Color32 cBrown = new Color32(139, 69, 19, 255);
    public Color32 cdBlack ;

    public bool isPlayerActive;
    // Start is called before the first frame update
    public Sprite[] sprites;
    public bool isFlying;
    
    public void Draw()
    {
        int randomRoot = Random.Range(0, roots.Count);
        for (int i = 0; i < roots.Count; i++)
        {
            
            if (i == randomRoot)
            {
                //roots[i].SetActive(true);
                roots[i].transform.GetComponent<SpriteRenderer>().color = cdBlack; 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        //roots[1].color= false;
    }
}
