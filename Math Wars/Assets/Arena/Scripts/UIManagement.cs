using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagement : MonoBehaviour
{
    public GameObject attack;
    public GameObject heal;
    [SerializeField]GameObject arithmetic;
    [SerializeField]GameObject algebra;
    [SerializeField]GameObject calculus;
    [SerializeField]GameObject choice1;
    [SerializeField]GameObject choice2;
    [SerializeField]GameObject choice3;
    [SerializeField]GameObject choice4;
    //[SerializeField]GameObject confirm;
    [SerializeField]GameObject confirmAttack;
    [SerializeField]GameObject confirmHeal;
    [SerializeField]GameObject timer;
    [SerializeField]GameObject question;
    public GameObject winPopUp;
    public Image winPopUpSprite;
    public GameObject popUpsBG;
    public GameObject statusScroll;
    public Text status;
 
public void ChooseAction()
{
//set attack and heal visible
    status.text = "";
    statusScroll.SetActive(false);
    attack.SetActive(true);
    heal.SetActive(true);  
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
    choice1.SetActive(false);
    choice2.SetActive(false);
    choice3.SetActive(false);
    choice4.SetActive(false);
    //confirm.SetActive(false);
    confirmAttack.SetActive(false);
    confirmHeal.SetActive(false);
    timer.SetActive(false);
    question.SetActive(false);
}

public void SelectTopic()
{
//set both attack and heal buttons invisible
//set choose question visible
    status.text = "";  
    statusScroll.SetActive(false);
    attack.SetActive(false);
    heal.SetActive(false);  
    arithmetic.SetActive(true);
    algebra.SetActive(true);
    calculus.SetActive(true);
    choice1.SetActive(false);
    choice2.SetActive(false);
    choice3.SetActive(false);
    choice4.SetActive(false);
    //confirm.SetActive(false);
    confirmAttack.SetActive(false);
    confirmHeal.SetActive(false);
    timer.SetActive(false);
    question.SetActive(false);

}

public void ChooseAnswer()
{
    status.text = "";
    statusScroll.SetActive(false);
    attack.SetActive(false);
    heal.SetActive(false);  
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
    choice1.SetActive(true);
    choice2.SetActive(true);
    choice3.SetActive(true);
    choice4.SetActive(true);
    //confirm.SetActive(true);
    timer.SetActive(true);
    question.SetActive(true);

}

public void EnemyTurn()
{
    attack.SetActive(false);
    heal.SetActive(false);  
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
    choice1.SetActive(false);
    choice2.SetActive(false);
    choice3.SetActive(false);
    choice4.SetActive(false);
   // confirm.SetActive(false);
    confirmAttack.SetActive(false);
    confirmHeal.SetActive(false);
    timer.SetActive(false);
    question.SetActive(false);
}

public void ShowAttack()
{
    confirmAttack.SetActive(true);
}
public void ShowHeal()
{
    confirmHeal.SetActive(true);
}

}

