using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterDescriptionController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string storyA;
    public string storyB;
    public string storyC;
    public Button buttonCharacterA;
    public Button buttonCharacterB;
    public Button buttonCharacterC;
    public Button buttonNext;

    private bool CharacterASelected = false;
    private bool CharacterBSelected = false;
    private bool CharacterCSelected = false;



    // Start is called before the first frame update
    void Start()
    {
        text.text = "Select a character.";
        buttonCharacterA.onClick.AddListener(buttonAClicked);
        buttonCharacterB.onClick.AddListener(buttonBClicked);
        buttonCharacterC.onClick.AddListener(buttonCClicked);
        buttonNext.onClick.AddListener(buttonNextClicked);
    }

    void buttonAClicked() {
        CharacterASelected = true;
        CharacterBSelected = false;
        CharacterCSelected = false;

        text.text = storyA;

        Image image = buttonCharacterA.GetComponent<Image>();
        Color c = image.color;
        c.a = 0;
        image.color = c;

        image = buttonCharacterB.GetComponent<Image>();
        c = image.color;
        c.a = 1;
        image.color = c;

        image = buttonCharacterC.GetComponent<Image>();
        c = image.color;
        c.a = 1;
        image.color = c;

    }
    
    void buttonBClicked() {
        CharacterASelected = false;
        CharacterBSelected = true;
        CharacterCSelected = false;

        text.text = storyB;
        
        Image image = buttonCharacterA.GetComponent<Image>();
        Color c = image.color;
        c.a = 1;
        image.color = c;

        image = buttonCharacterB.GetComponent<Image>();
        c = image.color;
        c.a = 0;
        image.color = c;

        image = buttonCharacterC.GetComponent<Image>();
        c = image.color;
        c.a = 1;
        image.color = c;

    }

    void buttonCClicked() {
        CharacterASelected = false;
        CharacterBSelected = false;
        CharacterCSelected = true;

        text.text = storyC;
        
        Image image = buttonCharacterA.GetComponent<Image>();
        Color c = image.color;
        c.a = 1;
        image.color = c;

        image = buttonCharacterB.GetComponent<Image>();
        c = image.color;
        c.a = 1;
        image.color = c;

        image = buttonCharacterC.GetComponent<Image>();
        c = image.color;
        c.a = 0;
        image.color = c;

    }

    void buttonNextClicked() {
        if(CharacterASelected) {
            Debug.Log("scene A");
        }
        else  {
            if(CharacterBSelected) {
                Debug.Log("scene B");
            }
            else {
                if(CharacterCSelected) {
                    Debug.Log("scene C");
                }
                else {
                    Debug.Log("No character selected");
                }
            }
        }
            
    }

}
