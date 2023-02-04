using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootManagerScript : MonoBehaviour
{
    public List<GameObject> roots;
    public Color32 cBrown = new Color32(139, 69, 19, 255);
    public Color32 cBlack = new Color32(0, 0, 0, 255);
    // Start is called before the first frame update
    Vector3 testvector = new Vector3(0, 1, 1);
    public void Draw()
    {
        int randomRoot = Random.Range(0, 5);
        for (int i = 0; i < roots.Count; i++)
        {
            if (i == randomRoot)
            {
                roots[i].SetActive(true);
                roots[i].GetComponent<SpriteRenderer>().color = cBlack;
            }
            else
            {
                roots[i].GetComponent<SpriteRenderer>().color = cBrown;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //roots[1].color= false;
    }
}
