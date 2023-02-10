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
    [SerializeField]GameObject QuitPopUp;
    [SerializeField]GameObject Transition;
    [SerializeField]CanvasGroup TownUI;
    [SerializeField]GameObject settingsBG;
    [SerializeField]GameObject tutorialTown;

    public Image img;

    public Animator animate;
    int firstLaunch;

void Awake()
{
      firstLaunch = PlayerPrefs.GetInt("firstLaunchGame", 0);
    if (firstLaunch == 0)
    {     
        Tutorial();
        PlayerPrefs.SetInt("firstLaunchGame", 1);
    }
    else
    {
        Transition.SetActive(true);

    }
}
public void Tutorial()
    {
        Instantiate(tutorialTown, new Vector3(0, 0, 0), Quaternion.identity);

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
    
    public void ShowQuit()
    {
        settingsBG.SetActive(true);
        QuitPopUp.SetActive(true);
    }
    public void closeExit()
    {
        settingsBG.SetActive(false);
        QuitPopUp.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
        
    }

    public void Settings()
    {
        settingsBG.SetActive(true);

        settings.SetActive(true);
        PopUpsUI.SetActive(true);
        TownUI.blocksRaycasts = false;
    }

    public void Reset()
    {
        resetConfirm.SetActive(true);
        settings.SetActive(false);

    }

    public void closeSettings()
    {
        settingsBG.SetActive(false);
        settings.SetActive(false);
        PopUpsUI.SetActive(false);
        TownUI.blocksRaycasts = true;


    }
    
    public void noReset()
    {
        resetConfirm.SetActive(false);
        settings.SetActive(true);

    }

    public void yesReset()
    {
        resetConfirm.SetActive(false);
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
