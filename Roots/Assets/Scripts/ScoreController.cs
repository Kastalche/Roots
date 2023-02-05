using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI textC;
    
    // Start is called before the first frame update
    void Start()
    {
        textC = GetComponent<TextMeshProUGUI>();
        textC.text = "HP: 10";
    }

    public void updateScore(int hp) {
        textC.text = "HP: " + hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
