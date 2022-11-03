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
        SceneManager.LoadScene(3);
    }
     public void Arena()
    {
        //StartCoroutine(Fade());
        SceneManager.LoadScene(2);
    }
     public void Home()
    {
        //StartCoroutine(Fade());   
        SceneManager.LoadScene(4);
    }
    
      /*  IEnumerator Fade()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        
    }
    */
}
