using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ArenaMenu : MonoBehaviour
{
public string difficulty;
[SerializeField]Text Wins;
[SerializeField]Text Level;
[SerializeField]Button confirm;
[SerializeField]GameObject tutorialPopup;
[SerializeField]GameObject tutorialUI;
[SerializeField]GameObject Transition;
[SerializeField]CanvasGroup arenaMenu;
[SerializeField]Image tutorialImage;
[SerializeField]GameObject tutorialBG;
[SerializeField]Slider PlayerXP;

public List<Sprite> tutorialImages = new List<Sprite>();
public Image img;

public Animator animate;

public int tutorialCount;
public int winCount;
public int experience;
public int playerLevel;
public int firstLaunch;

void Awake()
{
    Transition.SetActive(true);
}
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
    Level.text = "Level "+ playerLevel.ToString();
    PlayerXP.value = experience;
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
    tutorialCount = 0;
    tutorialPopup.SetActive(true);
    tutorialImage.sprite = tutorialImages[0];
    tutorialBG.SetActive(true);
    arenaMenu.blocksRaycasts = false;
}
public void CloseTutorial()
{
    tutorialPopup.SetActive(false);
    tutorialUI.SetActive(false);
    tutorialBG.SetActive(false);

    arenaMenu.blocksRaycasts = true;

}

public void NextTutorial()
{
    
        tutorialCount = tutorialCount + 1;
     
        if (tutorialCount == 1)
        {
            tutorialImage.sprite = tutorialImages[1];
        }
        else if (tutorialCount == 2)
        {
            tutorialImage.sprite = tutorialImages[2];
        }
        else if (tutorialCount == 3)
        {
            tutorialImage.sprite = tutorialImages[3];
        }
    
        else if (tutorialCount == 4)
        {
            tutorialImage.sprite = tutorialImages[4];
        }
    
        else if (tutorialCount == 5)
        {
            tutorialImage.sprite = tutorialImages[5];
        }
    
        else if (tutorialCount == 6)
        {
            tutorialImage.sprite = tutorialImages[6];
        }
        else if (tutorialCount == 7)
        {
            tutorialImage.sprite = tutorialImages[7];
        }
    
    if (tutorialCount == 8)
    {
        CloseTutorial(); 
    }

}
   IEnumerator Fade()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Arena");
    }
}
