using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BattleNew : MonoBehaviour
{

    public float timer;
    public bool runTimer = false;
    public int experience;
    public int accumulatedXP = 0;
    public string difficulty;
    public Image transition;
    public Animator animate;
    [SerializeField]GameObject player;
    [SerializeField]GameObject UIManager;
    [SerializeField]GameObject QuestionManager;
    [SerializeField]GameObject Transition;
    [SerializeField]GameObject AudioManager;
    [SerializeField]Text TimerUI;
    [SerializeField]Slider TimerCircle;
    [SerializeField]Button ConfirmAttack;
    [SerializeField]GameObject circularTimer;
    [SerializeField]GameObject XPText;
    [SerializeField]Animator dummy;
    [SerializeField] GameObject damageFX;
    [SerializeField] GameObject trigdamageFX;
    [SerializeField] GameObject caldamageFX;
    public GameObject playerClone;
    public Text AccumulatedXP;
    public Text RewardXPText;
    UIManagement UI;
    QuestionManagerNew questions;
    NewArenaAudio audioclips;
    int dice;
    public int rewardXP;   
    string topic;
    PlayerUnit player1;
    public int prefabIndex = 0;

//coroutine timers

WaitForSeconds dmgDelay = new WaitForSeconds(0.7f);
WaitForSeconds delay1 = new WaitForSeconds(1f);
WaitForSeconds delay15 = new WaitForSeconds(1.5f);
void Awake() 
{
    Transition.SetActive(true);
    circularTimer.SetActive(false);
    playerClone = (GameObject)Instantiate(player, new Vector3(-3.44f, 0.71f, 0), Quaternion.identity);

}
void Start()
{
    prefabIndex = 0;
    accumulatedXP = 0;
    audioclips = AudioManager.GetComponent<NewArenaAudio>();
    difficulty = PlayerPrefs.GetString("difficulty");
    experience = PlayerPrefs.GetInt("XP");
    Scene currentScene = SceneManager.GetActiveScene();
    StartCoroutine(SetupBattle());
}
IEnumerator SetupBattle()
{
    AccumulatedXP.text = "Accumulated XP: " + accumulatedXP;
    XPText.SetActive(false);
    player1 = playerClone.GetComponent<PlayerUnit>();
    UI = UIManager.GetComponent<UIManagement>();
    questions = QuestionManager.GetComponent<QuestionManagerNew>();
    yield return delay1;
    player1.IdleAnimate();
    damageFX.SetActive(false);
    trigdamageFX.SetActive(false);
    caldamageFX.SetActive(false);
    dummy.ResetTrigger("damaged");
    PlayerTurn();
    Timer();   
}
   
void PlayerTurn()
{
    ConfirmAttack.interactable = false;
    UI.SelectTopic();
}

public void AttackType(Button button)
{

topic = button.name;
UI.ChooseAnswer();
    Timer();
    runTimer = true;
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
    rewardXP = Random.Range(5,11);
    XPText.SetActive(true);
    RewardXPText.text = "For "+rewardXP+" XP:";

}  

public void CheckAnswerBtn()
{
    StartCoroutine(CheckAnswer());
}
IEnumerator CheckAnswer()
{
runTimer = false;
Timer();
    UI.EnemyTurn();
if (questions.correct)
    {
     questions.correctText.text = "";

            player1.AttackAnimate();
            questions.correctText.text = "CORRECT";                      
            UI.statusScroll.SetActive(true);
            yield return delay1;
            dummy.SetTrigger("damaged");
             switch (topic)
            {
            case "Algebra":
                accumulatedXP +=  rewardXP;
                damageFX.SetActive(true);
            break;
            case "Trigonometry":
                accumulatedXP += rewardXP;
                trigdamageFX.SetActive(true);
            break;
            case "Calculus":
                accumulatedXP += rewardXP;
                caldamageFX.SetActive(true);
            break;
            
        }
        }
        
        else
    {
        questions.correctText.text = "INCORRECT";
        UI.statusScroll.SetActive(true);  
    }
    StartCoroutine(SetupBattle());
}
   
public void ActivateAttack()
{
    ConfirmAttack.interactable = true;
}

public void Timer()
{


switch (difficulty)
{
case "Easy":
    TimerCircle.maxValue = 90f;
    timer = 90f;
break;

case "Normal":
    TimerCircle.maxValue = 60f;
    timer = 60f;
break;

case "Hard":
    TimerCircle.maxValue = 30f;
    timer = 30f;
break;
}

}

void FixedUpdate()
{
    if (runTimer)
    {
    circularTimer.SetActive(true);
    timer -= Time.deltaTime;
    TimerUI.text = timer.ToString("N0");
    TimerCircle.value = timer;
      if (timer <= 0.5f)
    {
        questions.correctText.text = "";
    }
    }
    else
    {
        circularTimer.SetActive(false);
    }
}

  public void Back()
    {
        StartCoroutine(FadeTown());
    }

  
      IEnumerator FadeTown()
    {
        experience += accumulatedXP;
        PlayerPrefs.SetInt("XP", experience);
        animate.SetBool("Fade", true);
        UI.winPopUp.SetActive(false);
        yield return new WaitUntil(() => transition.color.a == 1);
        SceneManager.LoadScene("Math Town");
    }

      
/*void AlgebraLevel5()
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
    */
}