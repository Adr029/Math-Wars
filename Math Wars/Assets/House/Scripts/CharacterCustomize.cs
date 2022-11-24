using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class CharacterCustomize : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer bodyPart;
    public GameObject character;
    public List<Sprite> options = new List<Sprite>();
    public List<Button> choices = new List<Button>();
    public int CharSprite;    
    public int characterOption = 0;
    public int playerLevel = 0;

    private void Awake() {
        playerLevel = PlayerPrefs.GetInt("Level");

        CharSprite = PlayerPrefs.GetInt("character", 0);
        characterOption = CharSprite;
        bodyPart.sprite = options[characterOption];
       
            if (playerLevel >= 1)
            {
                choices[1].interactable = true;
            }
            if (playerLevel >= 2)
            {
                choices[2].interactable = true;
            }
    }

    public void Customize (Button button)
    {
        characterOption = int.Parse(button.name);
        bodyPart.sprite = options[characterOption];

    }

    public void Save()
    {
        PlayerPrefs.SetInt("character", characterOption);
    }
}
