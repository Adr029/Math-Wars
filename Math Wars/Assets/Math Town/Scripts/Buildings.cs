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
        SceneManager.LoadScene("Arena");
    }
     public void House()
    {
        //StartCoroutine(Fade());   
        SceneManager.LoadScene("Home");
    }
    public void StoryMode()
    {
        SceneManager.LoadScene("Story Mode Map");
    }
    
      /*  IEnumerator Fade()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        
    }
    */
}
