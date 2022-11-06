using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagement : MonoBehaviour
{
    [SerializeField]GameObject attack;
    [SerializeField]GameObject heal;
    [SerializeField]GameObject arithmetic;
    [SerializeField]GameObject algebra;
    [SerializeField]GameObject calculus;
    [SerializeField]GameObject welcome;
    [SerializeField]GameObject attacking;

public void ChooseAction()
{
//set attack and heal visible
    attacking.SetActive(false);
    welcome.SetActive(false);
    attack.SetActive(true);
    heal.SetActive(true);  
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
}

public void SelectTopic()
{
//set both attack and heal buttons invisible
//set choose question visible
    attacking.SetActive(false);
    attack.SetActive(false);
    heal.SetActive(false);  
    arithmetic.SetActive(true);
    algebra.SetActive(true);
    calculus.SetActive(true);
}

public void EnemyTurn()
{
    attacking.SetActive(true);
    attack.SetActive(false);
    heal.SetActive(false);  
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
}

}

