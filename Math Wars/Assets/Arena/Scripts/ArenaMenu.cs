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

public int tutorialCount;
public int winCount;
public int experience;
public int playerLevel;

BattleManager battle;

void Start()
{   
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
    SceneManager.LoadScene("Arena");
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
            tutorialSample.GetComponent<Image>().color = new Color32(255,255,225,100);
        }
        else if (tutorialCount == 2)
        {
            tutorialSample.GetComponent<Image>().color = new Color32(155,255,225,100);
        }
        else if (tutorialCount == 3)
        {
            tutorialSample.GetComponent<Image>().color = new Color32(255,255,125,100);
        }
    
    if (tutorialCount == 4)
    {
        CloseTutorial(); 
    }

    //insert code for changing button from next to exit
    

}
}
