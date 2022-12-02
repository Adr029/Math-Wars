using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;

public class PlayerUnit : MonoBehaviour
{    

int bodySprite;
int headSprite;
[Header("Player Sprite")]

public int MaxHealth = 100;
public int CurrentHealth = 100;
[SerializeField] Animator animate;
[SerializeField]SpriteLibrary spritelibrary;
[SerializeField]SpriteResolver Head;


private void Awake() 
{
    headSprite = PlayerPrefs.GetInt("head");
    bodySprite = PlayerPrefs.GetInt("body");
}
public void Start()

{
        Head.SetCategoryAndLabel(Head.GetCategory(), headSprite.ToString());
        Head.ResolveSpriteToSpriteRenderer();
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
   /*
    public void AttackAnimate()
    {
        animate.SetTrigger("Attacking");
    }
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
