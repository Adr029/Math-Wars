using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.Experimental.U2D.Animation;

public class CharacterCustomize : MonoBehaviour
{
    [Header("Sprite to Change")]
    public GameObject playerPreview;
    public List<Sprite> headOptions = new List<Sprite>();
    public List<Button> headChoices = new List<Button>();
    public int headSprite;    
    public int headChosen = 0;
    public List<Sprite> bodyOptions = new List<Sprite>();
    public List<Button> bodyChoices = new List<Button>();
    public int bodySprite;    
    public int bodyChosen = 0;
    public int playerLevel = 0;

    PlayerUnit player;

[SerializeField]SpriteLibrary spritelibrary;
[SerializeField]SpriteResolver Head;
[SerializeField]SpriteResolver Body;

    private void Awake() {

        
        playerLevel = PlayerPrefs.GetInt("Level");

        headSprite = PlayerPrefs.GetInt("head", 0);
        bodySprite = PlayerPrefs.GetInt("body", 0);
        headChosen = headSprite;
        bodyChosen = bodySprite;
     
       
            if (playerLevel >= 1)
            {
                headChoices[0].interactable = true;
            }
            if (playerLevel >= 2)
            {
                headChoices[1].interactable = true;
            }
       
            if (playerLevel >= 1)
            {
                bodyChoices[1].interactable = true;
            }
    }

    public void SelectHead (Button button)
    {
        headChosen = int.Parse(button.name);
        Head.SetCategoryAndLabel(Head.GetCategory(), headChosen.ToString());
        Head.ResolveSpriteToSpriteRenderer();
    }

   public void SelectBody (Button button)
    {
        bodyChosen = int.Parse(button.name);
        Body.SetCategoryAndLabel(Body.GetCategory(), bodyChosen.ToString());
        Body.ResolveSpriteToSpriteRenderer();
    }
    public void Save()
    {
        PlayerPrefs.SetInt("head", headChosen);
        PlayerPrefs.SetInt("body", bodyChosen);
    }


    
}
