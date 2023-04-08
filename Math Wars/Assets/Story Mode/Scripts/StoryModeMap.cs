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
[SerializeField]GameObject nextButton;
[SerializeField]GameObject prevButton;
[SerializeField]GameObject locked;
[SerializeField]Button kingdom3;
public List<GameObject> levelComplete = new List<GameObject>();
public List<Sprite> tutorialImages = new List<Sprite>();
int kingdom1Complete = 0;
int kingdom2Complete = 0;
int kingdom3Complete = 0;
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
    kingdom1Complete = PlayerPrefs.GetInt("kingdom1Complete");
    kingdom2Complete = PlayerPrefs.GetInt("kingdom2Complete");
    kingdom3Complete = PlayerPrefs.GetInt("kingdom3Complete");

    if (kingdom1Complete == 1)
    {
        levelComplete[0].SetActive(true);
    }
    if (kingdom1Complete == 2)
    {
        levelComplete[1].SetActive(true);
    }
    if (kingdom1Complete == 3)
    {
        levelComplete[2].SetActive(true);
    }

    if (kingdom1Complete == 1 && kingdom2Complete == 1)
    {
        kingdom3.interactable = true;
        locked.SetActive(false);
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
    prevButton.SetActive(false);
    nextButton.SetActive(true);

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

        tutorialCount++;
        if (tutorialCount == 10)
        {
            CloseTutorial();
        }
        else
        {
            tutorialImage.sprite = tutorialImages[tutorialCount];            
        }
        prevButton.SetActive(true);
        nextButton.SetActive(true);
        //check actual count
       
}

public void PrevTutorial()
{
        tutorialCount--;
     
        if (tutorialCount == 0)
        {
            prevButton.SetActive(false);
        }
        tutorialImage.sprite = tutorialImages[tutorialCount];            

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
