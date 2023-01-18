using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryModeMap : MonoBehaviour
{

public string kingdomName;
[SerializeField]Button tutorial;
[SerializeField]GameObject tutorialPopup;
[SerializeField]GameObject tutorialUI;
[SerializeField]CanvasGroup mapUI;
[SerializeField]Image tutorialSample;
public int tutorialCount;

void Awake()
{
   tutorialCount = 0;
}

   public void Kingdom1()
   {
    kingdomName = "Kingdom1";    
    PlayerPrefs.SetString("kingdomName", kingdomName);
    SceneManager.LoadScene("Kingdom");

   }

  public void Kingdom2()
   {
    kingdomName = "Kingdom2";    
    PlayerPrefs.SetString("kingdomName", kingdomName);
    SceneManager.LoadScene("Kingdom");

   }

   public void Kingdom3()
   {
    kingdomName = "Kingdom3";    
    PlayerPrefs.SetString("kingdomName", kingdomName);
    SceneManager.LoadScene("Kingdom");

   }

   public void ShowTutorial()
{
    tutorialUI.SetActive(true);
    mapUI.blocksRaycasts = false;
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
    mapUI.blocksRaycasts = true;

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
