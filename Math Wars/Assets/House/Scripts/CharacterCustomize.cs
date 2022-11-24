using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class CharacterCustomize : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer head;
    public SpriteRenderer body;
    public GameObject character;
    public List<Sprite> headOptions = new List<Sprite>();
    public List<Button> headChoices = new List<Button>();
    public int headSprite;    
    public int headChosen = 0;
     public List<Sprite> bodyOptions = new List<Sprite>();
    public List<Button> bodyChoices = new List<Button>();
    public int bodySprite;    
    public int bodyChosen = 0;
    public int playerLevel = 0;

    private void Awake() {
        playerLevel = PlayerPrefs.GetInt("Level");

        headSprite = PlayerPrefs.GetInt("head", 0);
        bodySprite = PlayerPrefs.GetInt("body", 0);
        headChosen = headSprite;
        bodyChosen = bodySprite;
        head.sprite = headOptions[headChosen];
        body.sprite = bodyOptions[bodyChosen];
       
            if (playerLevel >= 1)
            {
                headChoices[1].interactable = true;
            }
            if (playerLevel >= 2)
            {
                headChoices[2].interactable = true;
            }
        body.sprite = bodyOptions[bodyChosen];
       
            if (playerLevel >= 1)
            {
                bodyChoices[1].interactable = true;
            }
    }

    public void SelectHead (Button button)
    {
        headChosen = int.Parse(button.name);
        head.sprite = headOptions[headChosen];  
    }
   public void SelectBody (Button button)
    {
        bodyChosen = int.Parse(button.name);
        body.sprite = bodyOptions[bodyChosen];
    }
    public void Save()
    {
        PlayerPrefs.SetInt("head", headChosen);
        PlayerPrefs.SetInt("body", bodyChosen);
    }
}
