using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
   public int MaxHealth;
   public int CurrentHealth;
    public void HealEnemy(int heal)
   {
    CurrentHealth += heal;

    if (CurrentHealth > 100)
    {
        CurrentHealth = 100;
    }
   }
   public void TakeDamage(int dmg)
   {
    CurrentHealth -= dmg;

    if (CurrentHealth < 0)
    {
        CurrentHealth = 0;
    }
   }
}
