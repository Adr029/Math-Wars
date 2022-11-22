using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CharacterCustomize : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer bodyPart;
    public SpriteRenderer partThumbnail;
    public GameObject character;
    public List<Sprite> options = new List<Sprite>();
    public int CharSprite;    
    public int currentOption = 0;

    private void Awake() {
        CharSprite = PlayerPrefs.GetInt("character", 0);
        currentOption = CharSprite;
        bodyPart.sprite = options[currentOption];
        partThumbnail.sprite = options[currentOption];
    }
    public void NextOption()
    {
        currentOption++;
        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }
    bodyPart.sprite = options[currentOption];
    partThumbnail.sprite = options[currentOption];
    }
    public void PreviousOption()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count -1;
        }
    bodyPart.sprite = options[currentOption];
    partThumbnail.sprite = options[currentOption];
    }

    public void Save()
    {
        PlayerPrefs.SetInt("character", currentOption);
    }
}
