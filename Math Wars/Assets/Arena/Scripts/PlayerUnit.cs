using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{    

int bodySprite;
int headSprite;
[Header("Player Sprite")]

public SpriteRenderer head;
public SpriteRenderer body;
public List<Sprite> headOptions = new List<Sprite>();
public List<Sprite> bodyOptions = new List<Sprite>();
public int MaxHealth = 100;
public int CurrentHealth = 100;
[SerializeField] Animator animate;

public void Start()

{
        headSprite = PlayerPrefs.GetInt("head");
        bodySprite = PlayerPrefs.GetInt("body");
        head.sprite = headOptions[headSprite];
        body.sprite = bodyOptions[bodySprite];
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
}
