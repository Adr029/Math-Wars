using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
   public int MaxHealth;
   public int CurrentHealth;
   [SerializeField] Animator animate;
   
    public void HealEnemy(int heal)
   {
    CurrentHealth += heal;

    if (CurrentHealth > MaxHealth)
    {
        CurrentHealth = MaxHealth;
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
    public void AttackAnimate()
    {
        animate.SetTrigger("Attacking");
    }
  
}
