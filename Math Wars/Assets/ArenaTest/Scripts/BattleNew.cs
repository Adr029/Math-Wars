using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BattleNew : MonoBehaviour
{

    float timer;
    bool runTimer = false;
    public int experience;
    int accumulatedXP = 0;
    string difficulty;
    public Image transition;
    public Animator animate;
    [SerializeField]GameObject player;
    [SerializeField]GameObject UIManager;
    [SerializeField]GameObject QuestionManager;
    [SerializeField]GameObject Transition;
    [SerializeField]GameObject AudioManager;
    [SerializeField]GameObject circleGroup4;
    [SerializeField]GameObject circleGroup3;
    [SerializeField]GameObject circleGroup2;
    [SerializeField]GameObject circleGroup1;
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
    int rewardXP;   
    string topic;
    PlayerUnit player1;
    public int prefabIndex = 0;
    int answerTarget;
    int correctAnswers;
    public List <GameObject> circles4;
    public List <GameObject> circles3;
    public List <GameObject> circles2;
    public List <GameObject> circles1;
    public Sprite circleBlank;
    public Sprite circleCorrect;
    

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
    answerTarget = 0;
    audioclips = AudioManager.GetComponent<NewArenaAudio>();
    difficulty = PlayerPrefs.GetString("difficulty");
    experience = PlayerPrefs.GetInt("XP");
    Scene currentScene = SceneManager.GetActiveScene();
    StartCoroutine(SetupBattle());
    RandomTarget();

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
    if (answerTarget == 1)
    {
        RewardXPText.text = "For  "+"<b>"+rewardXP+"</b>"+"  <b>XP</b>, answer  "+"<b>"+answerTarget+"</b>"+"  question correctly.";
    }
    else 
    {
        RewardXPText.text = "For  "+"<b>"+rewardXP+"</b>"+"  <b>XP</b>, answer  "+"<b>"+answerTarget+"</b>"+"  questions correctly.";
    }
    XPText.SetActive(true);
    switch (answerTarget)
        {
            case 1:
                circleGroup1.SetActive(true);
            break;
            case 2:
                circleGroup2.SetActive(true);
            break;
            case 3:
                circleGroup3.SetActive(true);
            break;
            case 4:
                circleGroup4.SetActive(true); 
            break;
        }    
    ConfirmAttack.interactable = false;
    UI.SelectTopic();

}

public void AttackType(Button button)
{
XPText.SetActive(false);
topic = button.name;
UI.ChooseAnswer();
    Timer();
    runTimer = true;
    switch (topic)
    {
    case "Algebra":
        switch (difficulty)
        {
        case "Easy":
            questions.BeginnerAlge();
        break;
        case "Normal":
            questions.IntermediateAlge();
        break;
        case "Hard":
            questions.AdvanceAlge();
        break;
        }
    break;
    case "Trigonometry":
        switch (difficulty)
        {
        case "Easy":
            questions.BeginnerTrigo();
        break;
        case "Normal":
            questions.IntermediateTrigo();
        break;
        case "Hard":
            questions.AdvanceTrigo();
        break;
        }
    break;
    case "Calculus":
        switch (difficulty)
        {
        case "Easy":
            questions.BeginnerCal();
        break;
        case "Normal":
            questions.IntermediateCal();
        break;
        case "Hard":
            questions.AdvanceCal();
        break;
        }
    break;
    }
    
}  
public void RandomTarget()
{
    correctAnswers = 0;

    circles1[0].GetComponent<SpriteRenderer>().sprite = circleBlank;

    circles2[0].GetComponent<SpriteRenderer>().sprite = circleBlank;
    circles2[1].GetComponent<SpriteRenderer>().sprite = circleBlank;

    circles3[0].GetComponent<SpriteRenderer>().sprite = circleBlank;
    circles3[1].GetComponent<SpriteRenderer>().sprite = circleBlank;
    circles3[2].GetComponent<SpriteRenderer>().sprite = circleBlank;

    circles4[0].GetComponent<SpriteRenderer>().sprite = circleBlank;
    circles4[1].GetComponent<SpriteRenderer>().sprite = circleBlank;
    circles4[2].GetComponent<SpriteRenderer>().sprite = circleBlank;
    circles4[3].GetComponent<SpriteRenderer>().sprite = circleBlank;
    answerTarget = Random.Range(1,5);
    switch (difficulty)
    {

        case "Easy":
        switch (answerTarget)
        {
            case 1:
                rewardXP = Random.Range(4,6);
            break;
            case 2:
                rewardXP = Random.Range(6,8);
            break;
            case 3:
                rewardXP = Random.Range(8,10);
            break;
            case 4:
                rewardXP = Random.Range(10,12);
            break;
         
        }
        break;
        case "Normal":
        switch (answerTarget)
        {
            case 1:
                rewardXP = Random.Range(6,8);
            break;
            case 2:
                rewardXP = Random.Range(8,10);
            break;
            case 3:
                rewardXP = Random.Range(10,12);
            break;
            case 4:
                rewardXP = Random.Range(12,14);
            break;
         
        }
        break;
        case "Hard":
        switch (answerTarget)
        {
            case 1:
                rewardXP = Random.Range(8,10);
            break;
            case 2:
                rewardXP = Random.Range(10,12);
            break;
            case 3:
                rewardXP = Random.Range(12,14);
            break;
            case 4:
                rewardXP = Random.Range(14,16);
            break;
         
        }        break;
    }
    
    circleGroup1.SetActive(false);
    circleGroup2.SetActive(false);
    circleGroup3.SetActive(false);
    circleGroup4.SetActive(false);

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
            correctAnswers++;
            switch (correctAnswers)
            {
                case 1:
                    circles1[0].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                    circles2[0].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                    circles3[0].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                    circles4[0].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                break;

                case 2:
                    circles2[1].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                    circles3[1].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                    circles4[1].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                break;

                case 3:
                    circles3[2].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                    circles4[2].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                break;

                case 4:
                    circles4[3].GetComponent<SpriteRenderer>().sprite = circleCorrect;
                break;
            }
            questions.correctText.text = "";
            audioclips.PlayPlayerAttack();
            player1.AttackAnimate();
            questions.correctText.text = "CORRECT";                      
            UI.statusScroll.SetActive(true);
            yield return delay1;
            dummy.SetTrigger("damaged");
             switch (topic)
            {
            case "Algebra":
                damageFX.SetActive(true);
            break;
            case "Trigonometry":
                trigdamageFX.SetActive(true);
            break;
            case "Calculus":
                caldamageFX.SetActive(true);
            break;
            
            }
            if (correctAnswers == answerTarget)
            {
                accumulatedXP += rewardXP;
                RandomTarget();
                
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
    timer = 60f;
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

      

}