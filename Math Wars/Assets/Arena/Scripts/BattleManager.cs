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
    public Text EnemyNameUI;
    public Text PlayerNameUI;
    public Text EnemyHealthUI;
    public Text PlayerHealthUI;

    string playerchoice;
//player and enemy future switch to read instantiated prefab    
    [SerializeField]GameObject player;
    [SerializeField]GameObject enemy;
    [SerializeField]GameObject UIManager;
   
    UIManagement UI;
    public BattleState state;
    
    string topic;

    EnemyUnit enemy1;
    PlayerUnit player1;

void Start()
{
    state = BattleState.START;
    StartCoroutine(SetupBattle());
    //skip muna test lang muna attack and damage, future spawning mechanic
}

IEnumerator SetupBattle()
{
    enemy1 = enemy.GetComponent<EnemyUnit>();
    player1 = player.GetComponent<PlayerUnit>();
    UI = UIManager.GetComponent<UIManagement>();
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
   UI.ChooseAction();
}

 public void Attack()
 {
   playerchoice = "Attack";
   UI.SelectTopic();
 }

 public void Heal()
 {
   playerchoice = "Heal";
   UI.SelectTopic();
 }

public void AttackType(Button button)
{

topic = button.name;

switch (playerchoice)
{
case "Attack":
    switch (topic)
    {
    case "Arithmetic":
        enemy1.TakeDamage(Random.Range(7,10));
    break;
    case "Algebra":
        enemy1.TakeDamage(Random.Range(12,15));
    break;
    case "Calculus":
        enemy1.TakeDamage(Random.Range(17,20));
    break;
    }
break; 

case "Heal":
    switch (topic)
    {
    case "Arithmetic":
        player1.HealPlayer(Random.Range(7,10));
    break;
    case "Algebra":
       player1.HealPlayer(Random.Range(12,15));
    break;
    case "Calculus":
        player1.HealPlayer(Random.Range(17,20));
    break;
    }
break;
}
    
    StartCoroutine(EnemyTurn());
    PlayerHealthUI.text = player1.CurrentHealth.ToString();
    EnemyHealthUI.text = enemy1.CurrentHealth.ToString();
}
IEnumerator EnemyTurn()
{
 state = BattleState.ENEMYTURN;
UI.EnemyTurn();
yield return new WaitForSeconds(2f);
player1.TakeDamage(Random.Range(7,20));
StartCoroutine(SetupBattle());

}
}