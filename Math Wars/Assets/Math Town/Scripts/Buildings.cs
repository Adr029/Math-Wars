using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Buildings : MonoBehaviour
{
    [SerializeField]GameObject settings;
    [SerializeField]GameObject resetConfirm;
    [SerializeField]GameObject restartApp;
    [SerializeField]GameObject PopUpsUI;
    [SerializeField]GameObject Transition;
    [SerializeField]CanvasGroup TownUI;
    public Image img;

    public Animator animate;
    
void Awake()
{
    Transition.SetActive(true);
}


   public void Library()
    {
        StartCoroutine(FadeLibrary());

    }
     public void Arena()
    {
        StartCoroutine(FadeArena());
        PlayerPrefs.SetInt("storymode", 0);
        
    }
     public void House()
    {
        StartCoroutine(FadeHouse());        
   
    }
    public void StoryMode()
    {
        StartCoroutine(FadeStory());   
        PlayerPrefs.SetInt("storymode", 1);        
        
    }
    public void Exit()
    {
        Application.Quit();
        
    }

    public void Settings()
    {
        settings.SetActive(true);
        PopUpsUI.SetActive(true);
        TownUI.blocksRaycasts = false;
    }

    public void Reset()
    {
        resetConfirm.SetActive(true);
    }

    public void closeSettings()
    {
        settings.SetActive(false);
        PopUpsUI.SetActive(false);
        TownUI.blocksRaycasts = true;


    }
    
    public void noReset()
    {
        resetConfirm.SetActive(false);
    }

    public void yesReset()
    {
        PlayerPrefs.DeleteAll();
        restartApp.SetActive(true);
    }
     public void appRestart()
    {
        Application.Quit();
    }

   IEnumerator FadeLibrary()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Library");

    }
   IEnumerator FadeArena()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("SelectDifficulty");

    }
   IEnumerator FadeStory()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Story Mode Map");

    }
   IEnumerator FadeHouse()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Home");

    }
    
}
