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
[SerializeField]GameObject Transition;
[SerializeField]CanvasGroup mapUI;
[SerializeField]Image tutorialSample;

//[SerializeField]Image tutorialImage;

public int tutorialCount;
public int firstLaunch;
public Image img;
public Animator animate;


void Awake()
{
    Transition.SetActive(true);
    tutorialCount = 0;
    firstLaunch = PlayerPrefs.GetInt("firstLaunchStory", 0);
    if (firstLaunch == 0)
    {
        ShowTutorial();
        PlayerPrefs.SetInt("firstLaunchStory", 1);
    }
    
}

   public void Kingdom1()
   {
        kingdomName = "Kingdom1";    
        PlayerPrefs.SetString("kingdomName", kingdomName);
        StartCoroutine(FadeKingdom());
   }

  public void Kingdom2()
   {
        kingdomName = "Kingdom2";    
        PlayerPrefs.SetString("kingdomName", kingdomName);
        StartCoroutine(FadeKingdom());
   }

   public void Kingdom3()
   {
        kingdomName = "Kingdom3";    
        PlayerPrefs.SetString("kingdomName", kingdomName);
        StartCoroutine(FadeKingdom());
   }

   public void ShowTutorial()
{
    tutorialUI.SetActive(true);
    //tutorialImage.sprite = tutorialImages[0];

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
 IEnumerator FadeKingdom()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Kingdom");

    }

}
