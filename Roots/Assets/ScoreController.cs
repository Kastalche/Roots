using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "HP: 10";
    }

    public void updateScore(int hp) {
        text.text = "HP: " + hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
