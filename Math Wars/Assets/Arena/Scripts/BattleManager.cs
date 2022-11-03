using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{


    [SerializeField]GameObject attack;
    [SerializeField]GameObject heal;
    [SerializeField]GameObject arithmetic;
    [SerializeField]GameObject algebra;
    [SerializeField]GameObject calculus;

 public void Attack()
 {
//set both attack and heal buttons invisible
//set choose question visible
    attack.SetActive(false);
    heal.SetActive(false);  
    arithmetic.SetActive(true);
    algebra.SetActive(true);
    calculus.SetActive(true);

 }

 public void Heal()
 {

//set both attack and heal buttons invisible
//set choose question visible
    attack.SetActive(false);
    heal.SetActive(false);  
    arithmetic.SetActive(true);
    algebra.SetActive(true);
    calculus.SetActive(true);
 }

 public void Arithmetic()
 {
//balik muna sa attack and heal
    attack.SetActive(true);
    heal.SetActive(true);  
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
 }


public void Algebra()
{
//balik muna sa attack and heal
    attack.SetActive(true);
    heal.SetActive(true);  
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
}

public void Calculus()
{
//balik muna sa attack and heal
    attack.SetActive(true);
    heal.SetActive(true);  
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
}
}