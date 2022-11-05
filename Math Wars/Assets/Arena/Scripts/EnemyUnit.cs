using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
   public string EnemyName;

   public int Damage;

   public int MaxHealth;

   public int CurrentHealth;

   public bool TakeDamage(int dmg)
   {
    CurrentHealth -= dmg;

    if (CurrentHealth <= 0)

    {
        return true;
    }

    else
    {
        return false;
    }
    
   }
}
