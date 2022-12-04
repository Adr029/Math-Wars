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

    // story mode variables
    string chosenKingdom;
    string selectedLevel;
    public int levelUnlocked;
    public List<Sprite> bgOptions = new List<Sprite>();

//end of story mode variables
    public SpriteRenderer background;
    [SerializeField]GameObject player;
    [SerializeField]GameObject UIManager;
    [SerializeField]GameObject ReturnToTown;
    [SerializeField]GameObject ReturnToMap;
    [SerializeField]GameObject QuestionManager;
    [SerializeField]Text TimerUI;
    [SerializeField]Slider PlayerHP;
    [SerializeField]Slider EnemyHP;
    [SerializeField]Button Confirm;

    GameObject playerClone;
    GameObject enemyClone;
    UIManagement UI;
    QuestionManagement questions;
    int dice;
    string topic;
    EnemyUnit enemy1;
    PlayerUnit player1;
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Enemy1;
    public GameObject Enemy2;
    int prefabIndex;
    int storyStatus;
    bool storyMode = false;

void Start()
{
    difficulty = PlayerPrefs.GetString("difficulty");
    storyStatus = PlayerPrefs.GetInt("storymode");
    experience = PlayerPrefs.GetInt("XP");
    winCount = PlayerPrefs.GetInt("wins");
    prefabList.Add(Enemy1);
    prefabList.Add(Enemy2);
    prefabIndex = UnityEngine.Random.Range(0,2);

    Scene currentScene = SceneManager.GetActiveScene();

    if (storyStatus > 0)
    {
        storyMode = true;
        chosenKingdom = PlayerPrefs.GetString("storyKingdom");
        selectedLevel = PlayerPrefs.GetString("selectedLevel");
        switch (chosenKingdom)
        {
            //change to custom bg for finalization
            case "Kingdom1":
                background.sprite = bgOptions[1];
            break;
            case "Kingdom2":
                background.sprite = bgOptions[2];
            break;
            case "Kingdom3":
                background.sprite = bgOptions[3];
            break;
        }
    }
    else
    {
     background.sprite = bgOptions[0];
    }

    BeginBattle();
}
public void BeginBattle()
{
    playerClone = (GameObject)Instantiate(player, new Vector3(-3.44f, 0.71f, 0), Quaternion.identity);
    
    if (storyMode)
    {

        if (selectedLevel == "10")
            {
                //king prefab
            }

        else
            {
                //normal enemy
                switch(prefabIndex)
                {
            case 0:
                enemyClone = (GameObject)Instantiate(prefabList[prefabIndex], new Vector3(3.44f, 0.96f, 0), Quaternion.identity);
            break;
            case 1:
                enemyClone = (GameObject)Instantiate(prefabList[prefabIndex], new Vector3(3.44f, 0.29f, 0), Quaternion.identity);
            break;
                }
        }     
    }
    else
    {
        switch(prefabIndex)
        {
            case 0:
                enemyClone = (GameObject)Instantiate(prefabList[prefabIndex], new Vector3(3.44f, 0.96f, 0), Quaternion.identity);
            break;
            case 1:
                enemyClone = (GameObject)Instantiate(prefabList[prefabIndex], new Vector3(3.44f, 0.29f, 0), Quaternion.identity);
            break;

        }
    }

    StartCoroutine(SetupBattle());

}

IEnumerator SetupBattle()
{
    enemy1 = enemyClone.GetComponent<EnemyUnit>();
    player1 = playerClone.GetComponent<PlayerUnit>();
    UI = UIManager.GetComponent<UIManagement>();
    questions = QuestionManager.GetComponent<QuestionManagement>();
    UpdateHealth();
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
   Confirm.interactable = false;
   enemy1.IdleAnimate();
}

 public void Attack()
 {
    playerchoice = "Attack";

    if(!storyMode)
    {
        UI.SelectTopic();
    }

    else
    {
        UI.ChooseAnswer();
        runTimer = true;

        switch (chosenKingdom)
        {
            case "Kingdom1":
                questions.Arithmetic();            
            break;
            case "Kingdom2":
                questions.Algebra();
            break;
            case "Kingdom3":
                questions.Calculus();
            break;
        }
    }
 }

 public void Heal()
 {
    if (player1.CurrentHealth < 100)
    {
        playerchoice = "Heal";
        if (!storyMode)
        {
            UI.SelectTopic();
        }
        else
        {
        UI.ChooseAnswer();
        runTimer = true;
        switch (chosenKingdom)
        {
            
            case "Kingdom1":
                questions.Arithmetic();            
            break;
            case "Kingdom2":
                questions.Algebra();
            break;
            case "Kingdom3":
                questions.Calculus();
            break;
        }
        }
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
if (!storyMode)
{
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
}
    UpdateHealth();

}
    
IEnumerator EnemyTurn()
{
runTimer = false;
if (enemy1.CurrentHealth < 100)
    {
     dice = Random.Range(0,6);
    }
    else
    {
    dice = Random.Range(0,5);  
    }
    UI.EnemyTurn();
yield return new WaitForSeconds(1f);
UI.status.text = "ENEMY TURN...";
UI.statusScroll.SetActive(true);     
questions.correctText.text = "";
yield return new WaitForSeconds(2f);

if (!storyMode)
{
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
case 4:
    UI.status.text = "ENEMY MISSED";
    UI.statusScroll.SetActive(true);  
break;
case 5:
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
}


else if (storyMode)
{
switch (dice)
{
case 0:
case 1:
case 2:
case 3:

//enemy attack
 
    switch (chosenKingdom)
    {
    case "Kingdom1":        
        player1.TakeDamage(Random.Range(7,11));
        UI.status.text = "ENEMY USED ARITHMETIC";
        UI.statusScroll.SetActive(true);  

    break;

    case "Kingdom2":        
    player1.TakeDamage(Random.Range(12,16));
        UI.status.text = "ENEMY USED ALGEBRA";
        UI.statusScroll.SetActive(true); 

    break;

    case "Kingdom3":        
    player1.TakeDamage(Random.Range(17,21));
        UI.status.text = "ENEMY USED CALCULUS";
        UI.statusScroll.SetActive(true); 
    break;
    }
enemy1.AttackAnimate();

break;
case 4:
    UI.status.text = "ENEMY MISSED";
    UI.statusScroll.SetActive(true);  
break;
case 5:
//enemy heal
UI.status.text = "ENEMY HEALED";
UI.statusScroll.SetActive(true); 
    switch (chosenKingdom)
    {

  case "Kingdom1":        
        enemy1.HealEnemy(Random.Range(11,16));
    break;
    case "Kingdom2":        
        enemy1.HealEnemy(Random.Range(19,25));
    break;
    case "Kingdom3":        
        enemy1.HealEnemy(Random.Range(27,33));
    break;  
    }
break;
}
}


StartCoroutine(SetupBattle());

}

void PlayerLose()
{
    UI.status.text = "YOU LOSE!";
    runTimer = false;
    if (!storyMode)
    {
        ReturnToTown.SetActive(true);
    }
    else if (storyMode)
    {
        ReturnToMap.SetActive(true);
    }
}

void PlayerWin()
{
    UI.EnemyTurn();
    UI.statusScroll.SetActive(true); 
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
    
    if (!storyMode)
    {
        ReturnToTown.SetActive(true);
    }

    else if (storyMode)
    {
        ReturnToMap.SetActive(true);

        switch (chosenKingdom)
        {
            case "Kingdom1":

            int kingdom1lvl = PlayerPrefs.GetInt("kingdom1Level");
            if (int.Parse(selectedLevel) == kingdom1lvl)
            {
                kingdom1lvl++;
                PlayerPrefs.SetInt("kingdom1Level", kingdom1lvl);
            }
        break;

            case "Kingdom2":
            int kingdom2lvl = PlayerPrefs.GetInt("kingdom2Level");
            if (int.Parse(selectedLevel) == kingdom2lvl)
            {
                kingdom2lvl++;
                PlayerPrefs.SetInt("kingdom2Level", kingdom2lvl);
            }
        break;

            case "Kingdom3":
            int kingdom3lvl = PlayerPrefs.GetInt("kingdom3Level");
            if (int.Parse(selectedLevel) == kingdom3lvl)
            {
                kingdom3lvl++;
                PlayerPrefs.SetInt("kingdom3Level", kingdom3lvl);
            }
        break;
        }
    }
}

public void ShowConfirm()
{

    Confirm.interactable = true;

}

public void CheckAnswer()
{
runTimer = false;
Timer();
if (questions.correct)
    {
        player1.AttackAnimate();
     questions.correctText.text = "";
    
        switch (playerchoice)
        {
        case "Attack":
            if (!storyMode)
            {
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
            }
           else if (storyMode)
           {
            switch(chosenKingdom)
            {
                case "Kingdom1":
                    enemy1.TakeDamage(Random.Range(7,11));
                break;

                case "Kingdom2":
                    enemy1.TakeDamage(Random.Range(12,16));
                break;
                case "Kingdom3":
                    enemy1.TakeDamage(Random.Range(17,21));
                break;
            }

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
        if (!storyMode)
        {
        switch (topic)
            {
            case "Arithmetic":
                player1.HealPlayer(Random.Range(11,16));
            break;
            case "Algebra":
                player1.HealPlayer(Random.Range(19,25));
            break;
            case "Calculus":
                player1.HealPlayer(Random.Range(27,33));
            break;
            }
        }
        else if (storyMode)
        {
            switch(chosenKingdom)
            {
            case "Kingdom1":
                player1.HealPlayer(Random.Range(11,16));
            break;
            case "Kingdom2":
                player1.HealPlayer(Random.Range(19,25));
            break;
            case "Kingdom3":
                player1.HealPlayer(Random.Range(27,33));
            break;
            }
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

if (!storyMode)
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

else
{
    timer = 60f;
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