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
    public List<Button> headChoices = new List<Button>();
    public int headSprite;    
    public int headChosen = 0;
    public List<Button> bodyChoices = new List<Button>();
    public int bodySprite;    
    public int bodyChosen = 0;
    public int playerLevel = 0;
    public int kingdom1Complete = 0;
    public int kingdom2Complete = 0;
    public int kingdom3Complete = 0;

    PlayerUnit player;

[SerializeField]SpriteLibrary spritelibrary;
[SerializeField]SpriteResolver Head;
[SerializeField]SpriteResolver Body;
[SerializeField]GameObject Transition;

    void Awake() {
        Transition.SetActive(true);

        playerLevel = PlayerPrefs.GetInt("Level");
        kingdom1Complete = PlayerPrefs.GetInt("kingdom1Complete");
        kingdom2Complete = PlayerPrefs.GetInt("kingdom2Complete");
        kingdom3Complete = PlayerPrefs.GetInt("kingdom3Complete");
        headSprite = PlayerPrefs.GetInt("head", 0);
        bodySprite = PlayerPrefs.GetInt("body", 0);
        headChosen = headSprite;
        bodyChosen = bodySprite;
     
       
            if (playerLevel >= 1)
            {
                headChoices[0].interactable = true;
                bodyChoices[1].interactable = true;
            }
            if (playerLevel >= 2)
            {
                headChoices[1].interactable = true;
            }
            // copy paste gang mabuo lahat
/*
            if (kingdom1Complete == 1)
            {
                //option.interactable = true;
            }
            if (kingdom2Complete == 1)
            {
                //option.interactable = true;
            }
            if (kingdom3Complete == 1)
            {
                //option.interactable = true;
            }
*/       
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
