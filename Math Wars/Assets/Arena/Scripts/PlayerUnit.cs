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
[SerializeField]SpriteResolver Head;
[SerializeField]SpriteResolver Body;
[SerializeField]SpriteResolver Weapon;


private void Awake() 
{
    headSprite = PlayerPrefs.GetInt("head");
    bodySprite = PlayerPrefs.GetInt("body");
    weaponSprite = PlayerPrefs.GetInt("weapon");

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
                fireballAnimate.SetTrigger("Attacking");
            break;
            case 1:
                effects[1].SetActive(true);
            break;
            case 2:
                effects[2].SetActive(true);
            break;
            case 3:
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
    
    public void ResetDmg()
    {

        effects[4].SetActive(false);
    }
    /*
    public void LoseAnimate()
    {
        animate.SetTrigger("Attacking");
    }
    public void WinAnimate()
    {
        animate.SetTrigger("Attacking");
    }
    */


}
