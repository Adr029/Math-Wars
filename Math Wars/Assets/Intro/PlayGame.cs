using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayGame : MonoBehaviour
{
    
    public Image transition;
    public Animator animate;
    public void Play()
   {
        StartCoroutine(FadeTown());
    }
      IEnumerator FadeTown()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => transition.color.a == 1);
        SceneManager.LoadScene("Math Town");
    }

}
