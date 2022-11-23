using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CharacterCustomize : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer bodyPart;
    public SpriteRenderer partThumbnail;
    public SpriteRenderer partThumbnailprevious;
    public SpriteRenderer partThumbnailnext;
    public GameObject character;
    public List<Sprite> options = new List<Sprite>();
    public int CharSprite;    
    public int currentOption = 0;

    private void Awake() {
        CharSprite = PlayerPrefs.GetInt("character", 0);
        currentOption = CharSprite;
        bodyPart.sprite = options[currentOption];
        partThumbnail.sprite = options[currentOption];
        if (currentOption != 2)
        {
        partThumbnailnext.sprite = options[currentOption + 1];
        }
        else
        {
        partThumbnailnext.sprite = options[0];
        }
        partThumbnailprevious.sprite = options[Mathf.Abs(currentOption - 1)];
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
     if (currentOption != 2)
        {
        partThumbnailnext.sprite = options[currentOption + 1];
        }
        else
        {
        partThumbnailnext.sprite = options[0];
        }
        if(currentOption != 0)
    {
        partThumbnailprevious.sprite = options[Mathf.Abs(currentOption - 1)];

    }
    else
    {
        partThumbnailprevious.sprite = options[2];

    }    
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
     if (currentOption != 2)
        {
        partThumbnailnext.sprite = options[currentOption + 1];
        }
        else
        {
        partThumbnailnext.sprite = options[0];
        }

    if(currentOption != 0)
    {
        partThumbnailprevious.sprite = options[Mathf.Abs(currentOption - 1)];

    }
    else
    {
        partThumbnailprevious.sprite = options[2];

    }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("character", currentOption);
    }
}
