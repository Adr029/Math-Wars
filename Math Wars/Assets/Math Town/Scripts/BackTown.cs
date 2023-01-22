using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BackTown : MonoBehaviour
{
    public Image img;

    public Animator animate;
   public void Back()
    {
        StartCoroutine(FadeTown());
    }
   public void ReturnPrevious()
    {
        StartCoroutine(FadeStory());
    }


      IEnumerator FadeTown()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Math Town");

    }
      IEnumerator FadeStory()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Story Mode Map");

    }
}
