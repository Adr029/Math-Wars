using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayGame : MonoBehaviour
{
    public GameObject transitionBG;
    public GameObject creditsPopUp;
    public Image transition;
    public Animator animate;

    int firstPlaythrough;

    void Awake()
    {
        transitionBG.SetActive(true);
        firstPlaythrough = PlayerPrefs.GetInt("firstPlaythrough", 0);
    }
    public void Play()
   {
        StartCoroutine(FadeTown());
    }
      IEnumerator FadeTown()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => transition.color.a == 1);
        if (firstPlaythrough == 0)
        {
            SceneManager.LoadScene("Story Cutscenes");


        }
        else
        {
            SceneManager.LoadScene("Math Town");
        }
    }

    public void ShowCredits()
    {
        creditsPopUp.SetActive(true);
    }
    public void CloseCredits()
    {
        creditsPopUp.SetActive(false);

    }

}
