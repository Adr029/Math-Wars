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
     public Image transition;

    public Animator animate;

    // story mode variables
    string chosenKingdom;
    string selectedLevel;
    public int levelUnlocked;
    public List<Sprite> bgOptions = new List<Sprite>();
    public List<Sprite> WinLose = new List<Sprite>();

//end of story mode variables
    public SpriteRenderer background;
    [SerializeField]GameObject player;
    [SerializeField]GameObject UIManager;
    [SerializeField]GameObject ReturnToTown;
    [SerializeField]GameObject ReturnToMap;
    [SerializeField]GameObject ReturnToKingdom;
    [SerializeField]GameObject QuestionManager;
    [SerializeField]GameObject Transition;
    [SerializeField]GameObject AudioManager;
    [SerializeField]Text TimerUI;
    [SerializeField]Slider PlayerHP;
    [SerializeField]Slider EnemyHP;
    [SerializeField]Button ConfirmAttack;
    [SerializeField]Button ConfirmHeal;
    [SerializeField]GameObject ConfirmAttackGO;
    [SerializeField]GameObject ConfirmHealGO;
    public GameObject playerClone;
    public GameObject enemyClone;
    UIManagement UI;
    QuestionManagement questions;
    ArenaAudio audioclips;
    int dice;
    string topic;
    EnemyUnit enemy1;
    PlayerUnit player1;
    List<GameObject> enemyPrefabs = new List<GameObject>();
    List<GameObject> kingPrefabs = new List<GameObject>();
    public GameObject Enemy1;
    public GameObject Enemy2;
    public int prefabIndex;
    int storyStatus;
    bool storyMode = false;
void Awake() 
{
    Transition.SetActive(true);
}
void Start()
{
    audioclips = AudioManager.GetComponent<ArenaAudio>();
    difficulty = PlayerPrefs.GetString("difficulty");
    storyStatus = PlayerPrefs.GetInt("storymode");
    experience = PlayerPrefs.GetInt("XP");
    winCount = PlayerPrefs.GetInt("wins");
    enemyPrefabs.Add(Enemy1);
    enemyPrefabs.Add(Enemy2);
    prefabIndex = UnityEngine.Random.Range(0,2);
    // for expansion pag dumami na enemies

    Scene currentScene = SceneManager.GetActiveScene();

    if (storyStatus > 0)
    {
        storyMode = true;
        chosenKingdom = PlayerPrefs.GetString("storyKingdom");
        selectedLevel = PlayerPrefs.GetString("selectedLevel");
        switch (chosenKingdom)
        {

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
    
    if (storyMode && selectedLevel == "5") //undergoing testing
    {
        switch (chosenKingdom)
            {
                case "Kingdom1":
                    //enemyClone = (GameObject)Instantiate(kingPrefabs[0], new Vector3(3.44f, 0.96f, 0), Quaternion.identity);
                    enemyClone = (GameObject)Instantiate(enemyPrefabs[1], new Vector3(3.44f, 0.96f, 0), Quaternion.identity);

                break;

                case "Kingdom2":
                    //enemyClone = (GameObject)Instantiate(kingPrefabs[1], new Vector3(3.44f, 0.96f, 0), Quaternion.identity);
                    enemyClone = (GameObject)Instantiate(enemyPrefabs[0], new Vector3(3.44f, 0.29f, 0), Quaternion.identity);

                break;

                case "Kingdom3":
                    //enemyClone = (GameObject)Instantiate(kingPrefabs[2], new Vector3(3.44f, 0.96f, 0), Quaternion.identity);
                    enemyClone = (GameObject)Instantiate(enemyPrefabs[1], new Vector3(3.44f, 0.29f, 0), Quaternion.identity);

                break;
            }
            
    }
    else
    {
        switch(prefabIndex)
        {
            case 0:
                enemyClone = (GameObject)Instantiate(enemyPrefabs[prefabIndex], new Vector3(3.44f, 0.96f, 0), Quaternion.identity);
            break;
            case 1:
                enemyClone = (GameObject)Instantiate(enemyPrefabs[prefabIndex], new Vector3(3.44f, 0.29f, 0), Quaternion.identity);
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
   switch (playerchoice)
    {
    case "Attack":
        ConfirmAttack.interactable = false;
        ConfirmHealGO.SetActive(false);  

    break;
        
    case "Heal":
        ConfirmHeal.interactable = false;
        ConfirmAttackGO.SetActive(false);

    break;
    }


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
        UI.ShowAttack();
        runTimer = true;

        switch (chosenKingdom)
        {
            case "Kingdom1":
                questions.Algebra(); 
            
                switch (selectedLevel)
                {
                    case "1":
                        questions.AlgebraLevel1(); 
                    break;
                    case "2":
                        questions.AlgebraLevel2(); 
                    break;
                    case "3":
                        questions.AlgebraLevel3(); 
                    break;
                    case "4":
                        questions.AlgebraLevel4(); 
                    break;
                    case "5":
                       AlgebraLevel5(); 
                    break;
                }           
                
            break;
            case "Kingdom2":
                questions.Trigonometry();
                 
                switch (selectedLevel)
                {
                    case "1":
                        questions.TrigonometryLevel1(); 
                    break;
                    case "2":
                        questions.TrigonometryLevel2(); 
                    break;
                    case "3":
                        questions.TrigonometryLevel3(); 
                    break;
                    case "4":
                        questions.TrigonometryLevel4(); 
                    break;
                    case "5":
                        TrigonometryLevel5(); 
                    break;
                }           
                
            break;
            case "Kingdom3":
                questions.Calculus();
                 
                switch (selectedLevel)
                {
                    case "1":
                        questions.CalculusLevel1(); 
                    break;
                    case "2":
                        questions.CalculusLevel2(); 
                    break;
                    case "3":
                        questions.CalculusLevel3(); 
                    break;
                    case "4":
                        questions.CalculusLevel4(); 
                    break;
                    case "5":
                        CalculusLevel5(); 
                    break;
                }           
                
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
        UI.ShowHeal();

        runTimer = true;
         switch (chosenKingdom)
        {
            case "Kingdom1":
            
                switch (selectedLevel)
                {
                    case "1":
                        questions.AlgebraLevel1(); 
                    break;
                    case "2":
                        questions.AlgebraLevel2(); 
                    break;
                    case "3":
                        questions.AlgebraLevel3(); 
                    break;
                    case "4":
                        questions.AlgebraLevel4(); 
                    break;
                    case "5":
                        AlgebraLevel5(); 
                    break;
                }           
                
            break;
            case "Kingdom2":
                 
                switch (selectedLevel)
                {
                    case "1":
                        questions.TrigonometryLevel1(); 
                    break;
                    case "2":
                        questions.TrigonometryLevel2(); 
                    break;
                    case "3":
                        questions.TrigonometryLevel3(); 
                    break;
                    case "4":
                        questions.TrigonometryLevel4(); 
                    break;
                    case "5":
                       TrigonometryLevel5(); 
                    break;
                }           
                
            break;
            case "Kingdom3":
                 
                switch (selectedLevel)
                {
                    case "1":
                        questions.CalculusLevel1(); 
                    break;
                    case "2":
                        questions.CalculusLevel2(); 
                    break;
                    case "3":
                        questions.CalculusLevel3(); 
                    break;
                    case "4":
                        questions.CalculusLevel4(); 
                    break;
                    case "5":
                        CalculusLevel5(); 
                    break;
                }           
                
            break;
        }
        }
    }
    else
    {
        StartCoroutine(fullHealth());
    }
 }
IEnumerator fullHealth()
{

    UI.status.text = "HEALTH ALREADY FULL!";
    UI.statusScroll.SetActive(true);
    UI.attack.SetActive(false);
    UI.heal.SetActive(false);
    yield return new WaitForSeconds(1.5f);
     UI.status.text = "";
    UI.statusScroll.SetActive(false);
    UI.attack.SetActive(true);
    UI.heal.SetActive(true);
}


public void AttackType(Button button)
{

topic = button.name;

UI.ChooseAnswer();
    
switch (playerchoice)
    {
    case "Attack":
        ConfirmAttack.interactable = false;
        ConfirmHealGO.SetActive(false);  
        UI.ShowAttack();

        
    break;
        
    case "Heal":
        ConfirmHeal.interactable = false;
        ConfirmAttackGO.SetActive(false);
        UI.ShowHeal();

        
    break;
    }

    Timer();
    runTimer = true;
if (!storyMode)
{
    switch (topic)
    {
    case "Algebra":
        questions.Algebra();
    break;
    case "Trigonometry":
        questions.Trigonometry();
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
player1.IdleAnimate();
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
        UI.status.text = "ENEMY USED ALGEBRA";
        UI.statusScroll.SetActive(true);  
        

    break;

    case 1:
        player1.TakeDamage(Random.Range(12,16));
        UI.status.text = "ENEMY USED TRIGONOMETRY";
        UI.statusScroll.SetActive(true); 

    break;

    case 2:
        player1.TakeDamage(Random.Range(17,21));
        UI.status.text = "ENEMY USED CALCULUS";
        UI.statusScroll.SetActive(true); 
    break;
    }

audioclips.PlayEnemyAttack();
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
            audioclips.PlayEnemyHeal();
    break;
    case 1:
        enemy1.HealEnemy(Random.Range(12,16));
            audioclips.PlayEnemyHeal();

    break;
    case 2:
        enemy1.HealEnemy(Random.Range(17,21));
            audioclips.PlayEnemyHeal();
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
        UI.status.text = "ENEMY USED ALGEBRA";
        UI.statusScroll.SetActive(true);  

    break;

    case "Kingdom2":        
    player1.TakeDamage(Random.Range(12,16));
        UI.status.text = "ENEMY USED TRIGONOMETRY";
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
        audioclips.PlayEnemyHeal();

    break;
    case "Kingdom2":        
        enemy1.HealEnemy(Random.Range(19,25));
        audioclips.PlayEnemyHeal();

    break;
    case "Kingdom3":        
        enemy1.HealEnemy(Random.Range(27,33));
        audioclips.PlayEnemyHeal();

    break;  
    }
break;
}
}


StartCoroutine(SetupBattle());

}

void PlayerLose()
{
    UI.statusScroll.SetActive(false);  
    StartCoroutine(ShowLose());
    runTimer = false;
    if (!storyMode)
    {
        ReturnToTown.SetActive(true);
    }
    else if (storyMode)
    {
        ReturnToMap.SetActive(true);
        ReturnToKingdom.SetActive(true);
    }
}

void PlayerWin()
{
    UI.statusScroll.SetActive(false);  
    enemy1.DeadAnimate();
    StartCoroutine(ShowWin());  
    runTimer = false;
    winCount += 1;
    PlayerPrefs.SetInt("wins", winCount);

    
    
    if (!storyMode)
    {
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

    else if (storyMode)
    {
        ReturnToKingdom.SetActive(true);
        ReturnToMap.SetActive(true);

        switch (chosenKingdom)
        {
            case "Kingdom1":
            experience += 15;
            int kingdom1lvl = PlayerPrefs.GetInt("kingdom1Level", 1);
            if (int.Parse(selectedLevel) == kingdom1lvl)
            {
                kingdom1lvl++;
                PlayerPrefs.SetInt("kingdom1Level", kingdom1lvl);
                if (kingdom1lvl > 5)
                {
                    PlayerPrefs.SetInt("kingdom1Complete", 1);

                }
            }
        break;

            case "Kingdom2":
            experience += 30;
            int kingdom2lvl = PlayerPrefs.GetInt("kingdom2Level", 1);
            if (int.Parse(selectedLevel) == kingdom2lvl)
            {
                kingdom2lvl++;
                PlayerPrefs.SetInt("kingdom2Level", kingdom2lvl);
            if (kingdom2lvl > 5)
                {
                    PlayerPrefs.SetInt("kingdom2Complete", 1);
                }
            }
            
        break;

            case "Kingdom3":
            experience += 45;
            int kingdom3lvl = PlayerPrefs.GetInt("kingdom3Level", 1);
            if (int.Parse(selectedLevel) == kingdom3lvl)
            {
                kingdom3lvl++;
                PlayerPrefs.SetInt("kingdom3Level", kingdom3lvl);
                if (kingdom3lvl > 5)
                {
                    PlayerPrefs.SetInt("kingdom3Complete", 1);
                }
            }
        break;
        }
            PlayerPrefs.SetInt("XP", experience);
    }
}


public void ShowConfirmAttackHeal()
{
    switch (playerchoice)
    {
    case "Attack":
        ConfirmAttack.interactable = true;
        ConfirmHealGO.SetActive(false);  
    break;
        
    case "Heal":
        ConfirmHeal.interactable = true;
        ConfirmAttackGO.SetActive(false);
    break;
    }
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
            player1.AttackAnimate();
            StartCoroutine(damageEnemy());
        break;
        
        case "Heal":
        if (!storyMode)
        {
        switch (topic)
            {
            case "Algebra":
                player1.HealPlayer(Random.Range(11,16));
                audioclips.PlayPlayerHeal();
            break;
            case "Trigonometry":
                player1.HealPlayer(Random.Range(19,25));
                audioclips.PlayPlayerHeal();
            break;
            case "Calculus":
                player1.HealPlayer(Random.Range(27,33));
                audioclips.PlayPlayerHeal();
            break;
            }
        }
        else if (storyMode)
        {
            switch(chosenKingdom)
            {
            case "Kingdom1":
                player1.HealPlayer(Random.Range(11,16));
                audioclips.PlayPlayerHeal();
            break;
            case "Kingdom2":
                player1.HealPlayer(Random.Range(19,25));
                audioclips.PlayPlayerHeal();
            break;
            case "Kingdom3":
                player1.HealPlayer(Random.Range(27,33));
                audioclips.PlayPlayerHeal();
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
IEnumerator damageEnemy(){
     // 100 muna for testing

    questions.correctText.text = "CORRECT";
    UI.statusScroll.SetActive(true);  
    UI.EnemyTurn();

            
    yield return new WaitForSeconds  (1.5f);
    if (!storyMode)
            {
            switch (topic)
                {
                case "Trigonometry":
                    enemy1.TakeDamage(Random.Range(7,11));
                    audioclips.PlayPlayerAttack();
                break;
                case "Algebra":
                    enemy1.TakeDamage(Random.Range(12,16));
                    audioclips.PlayPlayerAttack();
                break;
                case "Calculus":
                    enemy1.TakeDamage(Random.Range(17,21));
                    audioclips.PlayPlayerAttack();
                break;
                }
            }
           else if (storyMode)
           {
            switch(chosenKingdom)
            {
                case "Kingdom1":
                    //enemy1.TakeDamage(Random.Range(7,11));
                    enemy1.TakeDamage(100);
                    audioclips.PlayPlayerAttack();
                break;

                case "Kingdom2":
                    //enemy1.TakeDamage(Random.Range(12,16));
                    enemy1.TakeDamage(100);
                    audioclips.PlayPlayerAttack();
                break;
                case "Kingdom3":
                    //enemy1.TakeDamage(Random.Range(17,21));
                    enemy1.TakeDamage(100);
                    audioclips.PlayPlayerAttack();
                break;
            }

           }
            
            UpdateHealth();

            if (enemy1.CurrentHealth <= 0)
            {
                questions.correctText.text = "";
                PlayerWin();    
            }
            else
            {
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
    timer = 120f;
break;

case "Normal":
    timer = 90f;
break;

case "Hard":
    timer = 60f;
break;
}
}

else
{
    timer = 90f;
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
        StartCoroutine(FadeTown());
    }
       public void ReturnStory()
    {
        StartCoroutine(FadeStory());
    }
   public void ReturnKingdom()
    {
        StartCoroutine(FadeKingdom());
    }
      IEnumerator FadeTown()
    {
        animate.SetBool("Fade", true);
        UI.winPopUp.SetActive(false);
        yield return new WaitUntil(() => transition.color.a == 1);
        SceneManager.LoadScene("Math Town");

        
    }
   IEnumerator FadeStory()
    {
        animate.SetBool("Fade", true);
        UI.winPopUp.SetActive(false);
        yield return new WaitUntil(() => transition.color.a == 1);
        SceneManager.LoadScene("Story Mode Map");
   

    }
      IEnumerator FadeKingdom()
    {
        animate.SetBool("Fade", true);
        UI.winPopUp.SetActive(false);
        yield return new WaitUntil(() => transition.color.a == 1);       
        SceneManager.LoadScene("Kingdom");
        
    }
      IEnumerator ShowLose()
    {

    yield return new WaitForSeconds(3f);
     UI.winPopUp.SetActive(true);
    UI.winPopUpSprite.sprite = WinLose[1];
    UI.popUpsBG.SetActive(true);
    }
      IEnumerator ShowWin()
    {

    yield return new WaitForSeconds(3f);
     UI.winPopUp.SetActive(true);
    UI.winPopUpSprite.sprite = WinLose[0];
    UI.popUpsBG.SetActive(true);
    }

void AlgebraLevel5()
    {
        int dice2;
        dice2 = Random.Range(1,5);
        switch (dice2)
        {
            case 1:
                questions.AlgebraLevel1();
            break;

            case 2:
                questions.AlgebraLevel2();
            break;

            case 3:
                questions.AlgebraLevel3();
            break;

            case 4:
                questions.AlgebraLevel4();
            break;
  
        }

    }
void TrigonometryLevel5()
    {
        int dice2;
        dice2 = Random.Range(1,5);
        switch (dice2)
        {
            case 1:
                questions.TrigonometryLevel1();
            break;

            case 2:
                questions.TrigonometryLevel2();
            break;

            case 3:
                questions.TrigonometryLevel3();
            break;

            case 4:
                questions.TrigonometryLevel4();
            break;
  
        }

    }
void CalculusLevel5()
    {
        int dice2;
        dice2 = Random.Range(1,5);
        switch (dice2)
        {
            case 1:
                questions.CalculusLevel1();
            break;

            case 2:
                questions.CalculusLevel2();
            break;

            case 3:
                questions.CalculusLevel3();
            break;

            case 4:
                questions.CalculusLevel4();
            break;
  
        }

    }
}