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
    
    int currentOption = 0;
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
        if (currentOption <= 0)
        {
            currentOption = options.Count -1;
        }
    bodyPart.sprite = options[currentOption];
    partThumbnail.sprite = options[currentOption];
    }

    public void Save()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/Prefabs/player.prefab");
    }
}
