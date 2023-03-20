using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ArenaMenu : MonoBehaviour
{
public string difficulty;
[SerializeField]Text Level;
[SerializeField]Button confirm;
[SerializeField]GameObject tutorialPopup;
[SerializeField]GameObject tutorialUI;
[SerializeField]GameObject Transition;
[SerializeField]CanvasGroup arenaMenu;
[SerializeField]Image tutorialImage;
[SerializeField]GameObject tutorialBG;
[SerializeField]Slider PlayerXP;
[SerializeField]GameObject prevButton;
[SerializeField]GameObject nextButton;
public Text XP;

public List<Sprite> tutorialImages = new List<Sprite>();
public Image img;

public Animator animate;

public int tutorialCount;
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
    playerLevel = PlayerPrefs.GetInt("Level");
    Level.text = playerLevel.ToString();
    XP.text =  experience.ToString()+ "/100";        
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
    prevButton.SetActive(false);
    nextButton.SetActive(true);
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
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
        else if (tutorialCount == 2)
        {
            tutorialImage.sprite = tutorialImages[2];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
        else if (tutorialCount == 3)
        {
            tutorialImage.sprite = tutorialImages[3];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
    
        else if (tutorialCount == 4)
        {
            tutorialImage.sprite = tutorialImages[4];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
    
        else if (tutorialCount == 5)
        {
            tutorialImage.sprite = tutorialImages[5];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
    
        else if (tutorialCount == 6)
        {
            tutorialImage.sprite = tutorialImages[6];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
        else if (tutorialCount == 7)
        {
            tutorialImage.sprite = tutorialImages[7];
            prevButton.SetActive(true);
            nextButton.SetActive(false); 
        }
        

}

public void PrevTutorial()
{
    
        tutorialCount = tutorialCount - 1;
     
        if (tutorialCount == 0)
        {
            tutorialImage.sprite = tutorialImages[0];            
            prevButton.SetActive(false);
            nextButton.SetActive(true);
        }
        else if (tutorialCount == 1)
        {
            tutorialImage.sprite = tutorialImages[1];            
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
        else if (tutorialCount == 2)
        {
            tutorialImage.sprite = tutorialImages[2];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
        else if (tutorialCount == 3)
        {
            tutorialImage.sprite = tutorialImages[3];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
    
        else if (tutorialCount == 4)
        {
            tutorialImage.sprite = tutorialImages[4];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
    
        else if (tutorialCount == 5)
        {
            tutorialImage.sprite = tutorialImages[5];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
    
        else if (tutorialCount == 6)
        {
            tutorialImage.sprite = tutorialImages[6];
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
        else if (tutorialCount == 7)
        {
            tutorialImage.sprite = tutorialImages[7];
            prevButton.SetActive(true);
            nextButton.SetActive(false); 
        }
        
}

   IEnumerator Fade()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Arena");
    }
}
