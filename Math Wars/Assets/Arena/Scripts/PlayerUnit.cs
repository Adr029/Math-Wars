using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;

public class PlayerUnit : MonoBehaviour
{    
int weaponSprite;    
int bodySprite;
int headSprite;
[Header("Player Sprite")]

public int MaxHealth = 100;
public int CurrentHealth;
[SerializeField] Animator playerAnimate;
[SerializeField] Animator fireballAnimate;
[SerializeField]SpriteLibrary spritelibrary;
[SerializeField]SpriteResolver Head;
[SerializeField]SpriteResolver Body;
[SerializeField]SpriteResolver Weapon;


private void Awake() 
{
    headSprite = PlayerPrefs.GetInt("head");
    bodySprite = PlayerPrefs.GetInt("body");
    weaponSprite = PlayerPrefs.GetInt("body");

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
        fireballAnimate.SetTrigger("Attacking");
    }

    public void IdleAnimate()
    {
        fireballAnimate.ResetTrigger("Attacking");
    }
    /*
    public void HealAnimate()
    {
        animate.SetTrigger("Attacking");
    }
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
