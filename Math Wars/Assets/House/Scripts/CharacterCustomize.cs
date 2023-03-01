using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.Experimental.U2D.Animation;

public class CharacterCustomize : MonoBehaviour
{
    [Header("Head Sprites")]
    public List<Button> headChoices = new List<Button>();
    public List<GameObject> headLocks = new List<GameObject>();

    public int headSprite;    
    public int headChosen = 0;
    [Header("Body Sprites")]
    public List<Button> bodyChoices = new List<Button>();
    public List<GameObject> bodyLocks = new List<GameObject>();

    public int bodySprite;    
    public int bodyChosen = 0;
    [Header("Weapon Sprites")]
    public List<Button> weaponChoices = new List<Button>();
    public List<GameObject> weaponLocks = new List<GameObject>();
    public int weaponSprite;    
    public int weaponChosen = 0;
    public int playerLevel = 0;
    public int kingdom1Complete = 0;
    public int kingdom2Complete = 0;
    public int kingdom3Complete = 0;

    PlayerUnit player;

[SerializeField]SpriteLibrary spritelibrary;
[SerializeField]SpriteResolver Head;
[SerializeField]SpriteResolver Body;
[SerializeField]SpriteResolver Weapon;
[SerializeField]SpriteResolver RightHand;
[SerializeField]SpriteResolver LeftLeg;
[SerializeField]SpriteResolver RightLeg;
[SerializeField]GameObject Transition;

    void Awake() {
        Transition.SetActive(true);

        playerLevel = PlayerPrefs.GetInt("Level", 1);
        kingdom1Complete = PlayerPrefs.GetInt("kingdom1Complete");
        kingdom2Complete = PlayerPrefs.GetInt("kingdom2Complete");
        kingdom3Complete = PlayerPrefs.GetInt("kingdom3Complete");
        headSprite = PlayerPrefs.GetInt("head", 0);
        bodySprite = PlayerPrefs.GetInt("body", 0);
        weaponSprite = PlayerPrefs.GetInt("weapon", 0);
        headChosen = headSprite;
        bodyChosen = bodySprite;
        weaponChosen = weaponSprite;
     
       
            if (playerLevel >= 2)
            {
                headChoices[1].interactable = true;
                bodyChoices[1].interactable = true;
                weaponChoices[1].interactable = true;
                headLocks[1].SetActive(false);
                bodyLocks[1].SetActive(false);
                weaponLocks[1].SetActive(false);
            }
            if (playerLevel >= 3)
            {
                headChoices[2].interactable = true;
                bodyChoices[2].interactable = true;
                weaponChoices[2].interactable = true;
                headLocks[2].SetActive(false);
                bodyLocks[2].SetActive(false);
                weaponLocks[2].SetActive(false);                
            }
    
            if (playerLevel >= 4)
            {
                headChoices[3].interactable = true;
                bodyChoices[3].interactable = true;
                weaponChoices[3].interactable = true;
                headLocks[3].SetActive(false);
                bodyLocks[3].SetActive(false);
                weaponLocks[3].SetActive(false);                
            }
    
            if (playerLevel >= 5)
            {
                headChoices[4].interactable = true;
                bodyChoices[4].interactable = true;
                weaponChoices[4].interactable = true;
                headLocks[4].SetActive(false);
                bodyLocks[4].SetActive(false);
                weaponLocks[4].SetActive(false);                
            }
    

            if (kingdom1Complete == 1)
            {
                headChoices[5].interactable = true;
                bodyChoices[5].interactable = true;
                weaponChoices[5].interactable = true;
                headLocks[5].SetActive(false);
                bodyLocks[5].SetActive(false);
                weaponLocks[5].SetActive(false);  
 

            }
            if (kingdom2Complete == 1)
            {
                headChoices[6].interactable = true;
                bodyChoices[6].interactable = true;
                weaponChoices[6].interactable = true;
                headLocks[6].SetActive(false);
                bodyLocks[6].SetActive(false);
                weaponLocks[6].SetActive(false);  


            }
            if (kingdom3Complete == 1)
            {
                headChoices[7].interactable = true;
                bodyChoices[7].interactable = true;
                weaponChoices[7].interactable = true;
                headLocks[7].SetActive(false);
                bodyLocks[7].SetActive(false);
                weaponLocks[7].SetActive(false);  

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
        LeftLeg.SetCategoryAndLabel(LeftLeg.GetCategory(), bodyChosen.ToString());
        LeftLeg.ResolveSpriteToSpriteRenderer();
        RightHand.SetCategoryAndLabel(RightHand.GetCategory(), bodyChosen.ToString());
        RightHand.ResolveSpriteToSpriteRenderer();
        RightLeg.SetCategoryAndLabel(RightLeg.GetCategory(), bodyChosen.ToString());
        RightLeg.ResolveSpriteToSpriteRenderer();
    }
   public void SelectWeapon (Button button)
    {
        weaponChosen = int.Parse(button.name);
        Weapon.SetCategoryAndLabel(Weapon.GetCategory(), weaponChosen.ToString());
        Weapon.ResolveSpriteToSpriteRenderer();
    }
    public void Save()
    {
        PlayerPrefs.SetInt("head", headChosen);
        PlayerPrefs.SetInt("body", bodyChosen);
        PlayerPrefs.SetInt("weapon", weaponChosen);
    }


    public void UnlockAll()
    {

                headChoices[1].interactable = true;
                bodyChoices[1].interactable = true;
                weaponChoices[1].interactable = true;
                headLocks[1].SetActive(false);
                bodyLocks[1].SetActive(false);
                weaponLocks[1].SetActive(false);

                headChoices[2].interactable = true;
                bodyChoices[2].interactable = true;
                weaponChoices[2].interactable = true;
                headLocks[2].SetActive(false);
                bodyLocks[2].SetActive(false);
                weaponLocks[2].SetActive(false);

                headChoices[3].interactable = true;
                bodyChoices[3].interactable = true;
                weaponChoices[3].interactable = true;
                headLocks[3].SetActive(false);
                bodyLocks[3].SetActive(false);
                weaponLocks[3].SetActive(false); 

                headChoices[4].interactable = true;
                bodyChoices[4].interactable = true;
                weaponChoices[4].interactable = true;
                headLocks[4].SetActive(false);
                bodyLocks[4].SetActive(false);
                weaponLocks[4].SetActive(false);   

               headChoices[5].interactable = true;
                bodyChoices[5].interactable = true;
                weaponChoices[5].interactable = true;
                headLocks[5].SetActive(false);
                bodyLocks[5].SetActive(false);
                weaponLocks[5].SetActive(false);  

                headChoices[6].interactable = true;
                bodyChoices[6].interactable = true;
                weaponChoices[6].interactable = true;
                headLocks[6].SetActive(false);
                bodyLocks[6].SetActive(false);
                weaponLocks[6].SetActive(false); 

                headChoices[7].interactable = true;
                bodyChoices[7].interactable = true;
                weaponChoices[7].interactable = true;
                headLocks[7].SetActive(false);
                bodyLocks[7].SetActive(false);
                weaponLocks[7].SetActive(false);  

    }
}
