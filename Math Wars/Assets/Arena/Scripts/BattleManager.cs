using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState
{
START, PLAYERTURN, ENEMYTURN, WIN, LOSE

}
public class BattleManager : MonoBehaviour
{
//ui and buttons
    [SerializeField]GameObject attack;
    [SerializeField]GameObject heal;
    [SerializeField]GameObject arithmetic;
    [SerializeField]GameObject algebra;
    [SerializeField]GameObject calculus;
    [SerializeField]GameObject welcome;
    public Text EnemyNameUI;
    public Text PlayerNameUI;
    public Text EnemyHealthUI;
    public Text PlayerHealthUI;
//player and enemy future switch to read instantiated prefab    
    [SerializeField]GameObject player;
    [SerializeField]GameObject enemy;
   

    public BattleState state;
    
    string topic;

    EnemyUnit enemy1;
    PlayerUnit player1;

void Start()
{

    state = BattleState.START;
    StartCoroutine(SetupBattle());
 
    //skip muna test lang muna attack and damage
 
}

IEnumerator SetupBattle()
{

    enemy1 = enemy.GetComponent<EnemyUnit>();
    player1 = player.GetComponent<PlayerUnit>();

    PlayerNameUI.text = player1.PlayerName;
    EnemyNameUI.text = enemy1.EnemyName;
    PlayerHealthUI.text = player1.CurrentHealth.ToString();
    EnemyHealthUI.text = enemy1.CurrentHealth.ToString();

    yield return new WaitForSeconds(2f);
    state = BattleState.PLAYERTURN;

    PlayerTurn();
}

void PlayerTurn()
{
   ChooseAction();
}

 public void Attack()
 {
   Attacking();
 }

 public void Heal()
 {
   Attacking();
 }

public void AttackType(Button button)
{

topic = button.name;
switch (topic)
{
    case "Arithmetic":
        enemy1.TakeDamage(10);
        break;
    case "Algebra":
        enemy1.TakeDamage(15);
        break;

    case "Calculus":
        enemy1.TakeDamage(20);
        break;
}
    ChooseAction();
    StartCoroutine(SetupBattle());
}

void ChooseAction()
{
    //set attack and heal visible
    welcome.SetActive(false);
    attack.SetActive(true);
    heal.SetActive(true);  
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
}

void Attacking()
{
//set both attack and heal buttons invisible
//set choose question visible
    attack.SetActive(false);
    heal.SetActive(false);  
    arithmetic.SetActive(true);
    algebra.SetActive(true);
    calculus.SetActive(true);
}
}