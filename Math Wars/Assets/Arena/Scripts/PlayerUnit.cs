using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{    

    int CharSprite;
    [Header("Player Sprite")]

public SpriteRenderer bodyPart;
public List<Sprite> options = new List<Sprite>();
   public int MaxHealth = 100;
   public int CurrentHealth = 100;
public void Start()

{
    CharSprite = PlayerPrefs.GetInt("character");
    bodyPart.sprite = options[CharSprite];
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
}
