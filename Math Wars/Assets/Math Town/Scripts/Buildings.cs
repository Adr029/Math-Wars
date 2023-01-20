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
    [SerializeField]CanvasGroup TownUI;
   public void Library()
    {
        //StartCoroutine(Fade());
        SceneManager.LoadScene("Library");
    }
     public void Arena()
    {
        //StartCoroutine(Fade());
        PlayerPrefs.SetInt("storymode", 0);
        SceneManager.LoadScene("SelectDifficulty");
    }
     public void House()
    {
        //StartCoroutine(Fade());   
        SceneManager.LoadScene("Home");
    }
    public void StoryMode()
    {
        PlayerPrefs.SetInt("storymode", 1);
        SceneManager.LoadScene("Story Mode Map");
        
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

      /*  IEnumerator Fade()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        
    }
    */
}
