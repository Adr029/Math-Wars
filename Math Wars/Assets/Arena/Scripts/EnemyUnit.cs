using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
   public int MaxHealth;
   public int CurrentHealth;
   [SerializeField] Animator animate;
   [SerializeField] GameObject healAura;
   [SerializeField] GameObject damageFX;
   [SerializeField] GameObject trigdamageFX;
   [SerializeField] GameObject caldamageFX;
   
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
    public void HealAnimate()
    {
        healAura.SetActive(true);
    }
    public void ResetHeal()
    {
        healAura.SetActive(false);
    }
    public void DeadAnimate()
    {
        animate.SetTrigger("Dead");
    }
    public void WinAnimate()
    {
        animate.SetTrigger("Attacking");
    }
    public void IdleAnimate()
    {
        animate.ResetTrigger("Attacking");
    }
    public void DamageAnimate()
    {
        damageFX.SetActive(true);
    }
    public void TrigDamageAnimate()
    {
        trigdamageFX.SetActive(true);
    }
    public void CalDamageAnimate()
    {
        caldamageFX.SetActive(true);
    }
    public void ResetDamage()
    {
        damageFX.SetActive(false);
        trigdamageFX.SetActive(false);
        caldamageFX.SetActive(false);
    }
  
}
