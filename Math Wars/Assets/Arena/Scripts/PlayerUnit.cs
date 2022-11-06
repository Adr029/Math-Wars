using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public string PlayerName;

   public int MaxHealth;

   public int CurrentHealth;

   public void HealPlayer(int heal)
   {
    CurrentHealth += heal;
   }

   public void TakeDamage (int dmg)
   {
    CurrentHealth -= dmg;
   }
}
