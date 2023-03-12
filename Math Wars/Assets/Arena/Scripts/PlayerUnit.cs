using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;

public class PlayerUnit : MonoBehaviour
{    
public int weaponSprite;    
int bodySprite;
int headSprite;
[Header("Player Sprite")]

public int CurrentHealth;
[SerializeField] Animator playerAnimate;
[SerializeField] Animator fireballAnimate;
public List<GameObject> effects = new List<GameObject>();
public List<GameObject> deadFaces = new List<GameObject>();
[SerializeField]SpriteResolver Head;
[SerializeField]SpriteResolver Body;
[SerializeField]SpriteResolver Weapon;
[SerializeField]SpriteResolver RightHand;
[SerializeField]SpriteResolver LeftLeg;
[SerializeField]SpriteResolver RightLeg;

private void Awake() 
{
    headSprite = PlayerPrefs.GetInt("head", 0);
    bodySprite = PlayerPrefs.GetInt("body", 0);
    weaponSprite = PlayerPrefs.GetInt("weapon", 0);

}
public void Start()

{
        CurrentHealth = 100;
        Head.SetCategoryAndLabel(Head.GetCategory(), headSprite.ToString());
        Head.ResolveSpriteToSpriteRenderer();
        Body.SetCategoryAndLabel(Body.GetCategory(), bodySprite.ToString());
        Body.ResolveSpriteToSpriteRenderer();
        Weapon.SetCategoryAndLabel(Weapon.GetCategory(), weaponSprite.ToString());
        Weapon.ResolveSpriteToSpriteRenderer();
        LeftLeg.SetCategoryAndLabel(LeftLeg.GetCategory(), bodySprite.ToString());
        LeftLeg.ResolveSpriteToSpriteRenderer();
        RightHand.SetCategoryAndLabel(RightHand.GetCategory(), bodySprite.ToString());
        RightHand.ResolveSpriteToSpriteRenderer();
        RightLeg.SetCategoryAndLabel(RightLeg.GetCategory(), bodySprite.ToString());
        RightLeg.ResolveSpriteToSpriteRenderer();
}   

public void HealPlayer(int heal)
   {
    CurrentHealth += heal;

    if (CurrentHealth > 100)
    {
        CurrentHealth = 100;
    }
   }

   public void TakeDamage (int dmg)
   {
    CurrentHealth -= dmg;

     if (CurrentHealth < 0)
    {
        CurrentHealth = 0;
    }
   }

    public void AttackAnimate()
    {
        playerAnimate.SetTrigger("Attacking");
        //0 fireball, 1 crop, 2 water, 3 thunder, 4 damaged

        switch (weaponSprite)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
                fireballAnimate.SetTrigger("Attacking");
            break;
            case 5:
                effects[1].SetActive(true);
            break;
            case 6:
                effects[2].SetActive(true);
            break;
            case 7:
                effects[3].SetActive(true);
            break;
        }
    }

    public void IdleAnimate()
    {
        fireballAnimate.ResetTrigger("Attacking");
        effects[1].SetActive(false);
        effects[2].SetActive(false);
        effects[3].SetActive(false);
      

    }
    
    public void HealAnimate()
    {

        effects[0].SetActive(true);
    }
    
    public void ResetHeal()
    {

        effects[0].SetActive(false);
    }
    
    public void DmgAnimate()
    {

        effects[4].SetActive(true);
    }
    public void TrigDmgAnimate()
    {

        effects[5].SetActive(true);
    }
    public void CalDmgAnimate()
    {

        effects[6].SetActive(true);
    }
    
    public void ResetDmg()
    {

        effects[4].SetActive(false);
        effects[5].SetActive(false);
        effects[6].SetActive(false);
    }
    
    public void LoseAnimate()
    {
        deadFaces[headSprite].SetActive(true);
        playerAnimate.SetTrigger("Dead");
    }



}
