using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ArenaMenu : MonoBehaviour
{
public string difficulty;
[SerializeField]Text Wins;
[SerializeField]Text XP;
[SerializeField]Text Level;
[SerializeField]Button confirm;
[SerializeField]Button tutorial;
[SerializeField]GameObject tutorialPopup;
[SerializeField]GameObject tutorialUI;
[SerializeField]CanvasGroup arenaMenu;
[SerializeField]Image tutorialSample;

//[SerializeField]Image tutorialImage;
public List<Sprite> tutorialImages = new List<Sprite>();
public Image img;

public Animator animate;

public int tutorialCount;
public int winCount;
public int experience;
public int playerLevel;
public int firstLaunch;

BattleManager battle;

void Start()
{   
    firstLaunch = PlayerPrefs.GetInt("firstLaunchArena", 0);
    if (firstLaunch == 0)
    {
        ShowTutorial();
        PlayerPrefs.SetInt("firstLaunchArena", 1);
    }
    
    experience = PlayerPrefs.GetInt("XP");
    winCount = PlayerPrefs.GetInt("wins");
    playerLevel = PlayerPrefs.GetInt("Level");
    Wins.text = winCount.ToString() + " WINS";
    XP.text = "XP: " + experience.ToString()+ "/100";
    Level.text = "Level "+ playerLevel.ToString();
    tutorialCount = 0;
}
public void ChooseDifficulty(Button button)
{
    difficulty = button.name;
    confirm.interactable = true;
}

public void Confirm()
{
if (difficulty.Length != 0)
{
    PlayerPrefs.SetString("difficulty", difficulty);
    StartCoroutine(Fade());

    
}
}

public void ShowTutorial()
{
    tutorialUI.SetActive(true);
    arenaMenu.blocksRaycasts = false;
     if (!tutorialPopup.activeSelf)
    {
        tutorialCount = 0;
        tutorialPopup.SetActive(true);
        //tutorialImage.sprite = tutorialImages[0];
        tutorialSample.GetComponent<Image>().color = new Color32(21,232,225,100);

    }
}
public void CloseTutorial()
{
    tutorialPopup.SetActive(false);
    tutorialUI.SetActive(false);
    arenaMenu.blocksRaycasts = true;

}

public void NextTutorial()
{
    
        tutorialCount = tutorialCount + 1;
     
        if (tutorialCount == 1)
        {
            //tutorialImage.sprite = tutorialImages[1];
            tutorialSample.GetComponent<Image>().color = new Color32(255,255,225,100);
        }
        else if (tutorialCount == 2)
        {
            //tutorialImage.sprite = tutorialImages[2];
            tutorialSample.GetComponent<Image>().color = new Color32(155,255,225,100);
        }
        else if (tutorialCount == 3)
        {
            //tutorialImage.sprite = tutorialImages[3];
            tutorialSample.GetComponent<Image>().color = new Color32(255,255,125,100);
        }
    
    if (tutorialCount == 4)
    {
        CloseTutorial(); 
    }

    //insert code for changing button from next to exit

}
   IEnumerator Fade()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Arena");
    }
}
