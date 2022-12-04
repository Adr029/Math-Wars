using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Buildings : MonoBehaviour
{
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
    
      /*  IEnumerator Fade()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        
    }
    */
}
