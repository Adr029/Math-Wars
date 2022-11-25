using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BattleManager : MonoBehaviour
{
    public Text EnemyHealthUI;
    public Text PlayerHealthUI;
    public float timer;
    public bool runTimer = false;
    public int winCount;
    public int experience;
    public string difficulty;
    string playerchoice;
    [SerializeField]GameObject player;
    [SerializeField]GameObject UIManager;
    [SerializeField]GameObject ReturnToTown;
    [SerializeField]GameObject QuestionManager;
    [SerializeField]GameObject ArenaMenu;
    [SerializeField]Text TimerUI;
    [SerializeField]Slider PlayerHP;
    [SerializeField]Slider EnemyHP;
    GameObject playerClone;
    GameObject enemyClone;
    UIManagement UI;
    QuestionManagement questions;
    ArenaMenu menu;
    int dice;
    string topic;
    EnemyUnit enemy1;
    PlayerUnit player1;
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Enemy1;
    public GameObject Enemy2;

    int prefabIndex;

void Start()
{
    experience = PlayerPrefs.GetInt("XP");
    winCount = PlayerPrefs.GetInt("wins");
    prefabList.Add(Enemy1);
    prefabList.Add(Enemy2);
    prefabIndex = UnityEngine.Random.Range(0,2);
    
}
public void BeginBattle()
{
    playerClone = (GameObject)Instantiate(player, new Vector3(-3, 0, 0), Quaternion.identity);
    enemyClone = (GameObject)Instantiate(prefabList[prefabIndex], new Vector3(3, 0, 0), Quaternion.identity);
    StartCoroutine(SetupBattle());

}

IEnumerator SetupBattle()
{
    enemy1 = enemyClone.GetComponent<EnemyUnit>();
    player1 = player.GetComponent<PlayerUnit>();
    UI = UIManager.GetComponent<UIManagement>();
    questions = QuestionManager.GetComponent<QuestionManagement>();
    menu = ArenaMenu.GetComponent<ArenaMenu>();
    UpdateHealth();
    difficulty = menu.difficulty;
    if (player1.CurrentHealth <= 0)
    {
        PlayerLose();
    }
    else
    {
        yield return new WaitForSeconds(2f);
        PlayerTurn();
        Timer();
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
    UI.statusScroll.SetActive(true);
    UI.attack.SetActive(false);
    UI.heal.SetActive(false);
    }
 }

public void AttackType(Button button)
{

topic = button.name;

UI.ChooseAnswer();
    
    Timer();
    runTimer = true;

    switch (topic)
    {
    case "Arithmetic":
        questions.Arithmetic();
    break;
    case "Algebra":
        questions.Algebra();
    break;
    case "Calculus":
        questions.Calculus();
    break;
    }
  
    UpdateHealth();

}
    
IEnumerator EnemyTurn()
{
runTimer = false;
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
UI.statusScroll.SetActive(true);     
questions.correctText.text = "";
yield return new WaitForSeconds(2f);

switch (dice)
{
case 0:
case 1:
case 2:

//enemy attack
    dice = Random.Range(0,3);
    switch (dice)
    {
    case 0:
        player1.TakeDamage(Random.Range(7,11));
        UI.status.text = "ENEMY USED ARITHMETIC";
        UI.statusScroll.SetActive(true);  

    break;

    case 1:
        player1.TakeDamage(Random.Range(12,16));
        UI.status.text = "ENEMY USED ALGEBRA";
        UI.statusScroll.SetActive(true); 

    break;

    case 2:
        player1.TakeDamage(Random.Range(17,21));
        UI.status.text = "ENEMY USED CALCULUS";
        UI.statusScroll.SetActive(true); 
    break;
    }
enemy1.AttackAnimate();

break;
case 3:
    UI.status.text = "ENEMY MISSED";
    UI.statusScroll.SetActive(true);  
break;
case 4:
//enemy heal
dice = Random.Range(0,3);
UI.status.text = "ENEMY HEALED";
UI.statusScroll.SetActive(true); 
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
    runTimer = false;
    ReturnToTown.SetActive(true);
}

void PlayerWin()
{
    UI.EnemyTurn();
    UI.status.text = "YOU WIN!";
    enemy1.DeadAnimate();

    runTimer = false;
    winCount += 1;
    PlayerPrefs.SetInt("wins", winCount);

    switch (difficulty)
    {
    case "Easy":
        experience += 15;
    break;

    case "Normal":
        experience += 30;
    break;

    case "Hard":
        experience += 45;
    break;
    }
    PlayerPrefs.SetInt("XP", experience);
    ReturnToTown.SetActive(true);
}

public void CheckAnswer()
{
runTimer = false;
Timer();
if (questions.correct)
    {
     questions.correctText.text = "";
    
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
            
            UpdateHealth();

            if (enemy1.CurrentHealth <= 0)
            {
                PlayerWin();
            }
            else 
            {
                questions.correctText.text = "CORRECT";
                UI.statusScroll.SetActive(true);  
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
            questions.correctText.text = "CORRECT";                      
            UI.statusScroll.SetActive(true);  
            UpdateHealth();


            StartCoroutine(EnemyTurn());

        break;

        }
       
    }
    else
    {
        questions.correctText.text = "INCORRECT";
        UI.statusScroll.SetActive(true);  
        StartCoroutine(EnemyTurn());
    }
}

public void Timer()
{
switch (difficulty)
{
case "Easy":
    timer = 90f;
break;

case "Normal":
    timer = 60f;
break;

case "Hard":
    timer = 30f;
break;
}
}

public void UpdateHealth()
{
    PlayerHealthUI.text = player1.CurrentHealth.ToString();
    EnemyHealthUI.text = enemy1.CurrentHealth.ToString();
    EnemyHP.value = enemy1.CurrentHealth;
    PlayerHP.value = player1.CurrentHealth;
}
void FixedUpdate()
{
    if (runTimer)
    {
    timer -= Time.deltaTime;
    TimerUI.text = timer.ToString("N0"); 
      if (timer <= 0.5f)
    {
        questions.correctText.text = "";
        StartCoroutine(EnemyTurn());
    }
    }
}
public void Back()
    {
        Destroy(playerClone);
        Destroy(enemyClone);
        SceneManager.LoadScene("Math Town");
    }
}