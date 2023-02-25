using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryModeMap : MonoBehaviour
{

public string kingdomName;
[SerializeField]GameObject tutorialPopup;
[SerializeField]GameObject tutorialUI;
[SerializeField]GameObject selectionPopup;
[SerializeField]GameObject selectionUI;
[SerializeField]GameObject Transition;
[SerializeField]GameObject tutorialBG;
[SerializeField]CanvasGroup mapUI;
[SerializeField]Image tutorialImage;
public List<Sprite> tutorialImages = new List<Sprite>();

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
    tutorialCount = 0;
    tutorialPopup.SetActive(true);
    tutorialImage.sprite = tutorialImages[0];
    selectionUI.SetActive(false);

  
}
public void CloseTutorial()
{
    tutorialPopup.SetActive(false);
    tutorialUI.SetActive(false);
    mapUI.blocksRaycasts = true;

}
public void OpenSelection()
{
    selectionPopup.SetActive(true);
    selectionUI.SetActive(true);
    mapUI.blocksRaycasts = true;

}
public void CloseSelection()
{
    selectionPopup.SetActive(false);
    selectionUI.SetActive(false);
    mapUI.blocksRaycasts = true;

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
    
    
     if (tutorialCount == 7)
    {
        CloseTutorial(); 
    }

    

}

public void ShowStory()
{
    StartCoroutine(FadeStoryCutscene());
}
 IEnumerator FadeKingdom()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Kingdom");

    }
 IEnumerator FadeStoryCutscene()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Story Cutscenes");

    }

}
