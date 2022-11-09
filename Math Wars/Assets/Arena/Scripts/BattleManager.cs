using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    [SerializeField]GameObject QuestionManager;
    UIManagement UI;

    QuestionManagement questions;
    int dice;
    string topic;

    EnemyUnit enemy1;
    PlayerUnit player1;

void Start()
{
    StartCoroutine(SetupBattle());
    //skip muna test lang muna attack and damage, future spawning mechanic
}

IEnumerator SetupBattle()
{
    enemy1 = enemy.GetComponent<EnemyUnit>();
    player1 = player.GetComponent<PlayerUnit>();
    UI = UIManager.GetComponent<UIManagement>();
    questions = QuestionManager.GetComponent<QuestionManagement>();
    PlayerNameUI.text = player1.PlayerName;
    EnemyNameUI.text = enemy1.EnemyName;
    PlayerHealthUI.text = player1.CurrentHealth.ToString();
    EnemyHealthUI.text = enemy1.CurrentHealth.ToString();

    yield return new WaitForSeconds(2f);

    if (player1.CurrentHealth <= 0)
    {
        PlayerLose();
    }
    else if (enemy1.CurrentHealth <= 0)
    {
        PlayerWin();
    }
     else 
    {
        PlayerTurn();
    }
    
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
    if (player1.CurrentHealth < 100)
    {
        playerchoice = "Heal";
        UI.SelectTopic();
    }
    else
    {

    UI.status.text = "HEALTH ALREADY FULL!";        
    }

 }

public void AttackType(Button button)
{

topic = button.name;


UI.ChooseAnswer();
    switch (topic)
    {
    case "Arithmetic":
    questions.Arithmetic();
    break;
    case "Algebra":
        questions.Arithmetic();
    break;
    case "Calculus":
        questions.Arithmetic();
    break;
    }
    PlayerHealthUI.text = player1.CurrentHealth.ToString();
    EnemyHealthUI.text = enemy1.CurrentHealth.ToString();
}
    

 
IEnumerator EnemyTurn()
{
if (enemy1.CurrentHealth < 100)
    {
     dice = Random.Range(0,5);
    }
    else
    {
    dice = Random.Range(0,4);  
    }
    UI.EnemyTurn();
yield return new WaitForSeconds(1f);
UI.status.text = "ENEMY TURN...";    
questions.question.text = "";
yield return new WaitForSeconds(2f);

switch (dice)
{
case 0:
case 1:
case 2:
case 3:
//enemy attack
    dice = Random.Range(0,3);
    switch (dice)
    {
    case 0:
        player1.TakeDamage(Random.Range(7,11));
        UI.status.text = "ENEMY USED ARITHMETIC!";
    break;

    case 1:
        player1.TakeDamage(Random.Range(12,16));
        UI.status.text = "ENEMY USED ALGEBRA!";
    break;

    case 2:
        player1.TakeDamage(Random.Range(17,21));
        UI.status.text = "ENEMY USED CALCULUS!";
    break;
    }
break;
// di pa gumagana yung heal or malas lang sa chance
case 4:
//enemy heal
dice = Random.Range(0,3);
UI.status.text = "ENEMY HEALED";
    switch (dice)
    {
    case 0:
        enemy1.HealEnemy(Random.Range(7,11));
    break;
    case 1:
        enemy1.HealEnemy(Random.Range(12,16));
    break;
    case 2:
        enemy1.HealEnemy(Random.Range(17,21));
    break;
    }
break;
}
StartCoroutine(SetupBattle());
}

void PlayerLose()
{
    UI.status.text = "YOU LOSE!";
}

void PlayerWin()
{
    UI.EnemyTurn();
    UI.status.text = "YOU WIN!";
}

public void CheckAnswer()
{
if (questions.correct)
    {
     questions.question.text = "";
  
        switch (playerchoice)
        {
        case "Attack":
             switch (topic)
            {
            case "Arithmetic":
                enemy1.TakeDamage(Random.Range(7,11));
            break;
            case "Algebra":
                enemy1.TakeDamage(Random.Range(12,16));
            break;
            case "Calculus":
                enemy1.TakeDamage(Random.Range(17,21));
            break;
            }
             EnemyHealthUI.text = enemy1.CurrentHealth.ToString();
            if (enemy1.CurrentHealth <= 0)
            {
                PlayerWin();
            }
            else 
            {
                StartCoroutine(EnemyTurn());
            }
        break;
        
        case "Heal":
            switch (topic)
            {
            case "Arithmetic":
                player1.HealPlayer(Random.Range(7,11));
            break;
            case "Algebra":
                player1.HealPlayer(Random.Range(12,16));
            break;
            case "Calculus":
                player1.HealPlayer(Random.Range(17,21));
            break;
            }
            PlayerHealthUI.text = player1.CurrentHealth.ToString();
            StartCoroutine(EnemyTurn());

        break;

        }
       
    }
    else
    {
        questions.question.text = "INCORRECT";
        StartCoroutine(EnemyTurn());
    }

}

}