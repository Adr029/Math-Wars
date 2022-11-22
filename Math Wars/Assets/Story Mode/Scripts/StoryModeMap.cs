using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryModeMap : MonoBehaviour
{
    // Start is called before the first frame update
   public void Kingdom1()
   {
    SceneManager.LoadScene("Kingdom1");
   }

  public void Kingdom2()
   {
    SceneManager.LoadScene("Kingdom2");

   }

   public void Kingdom3()
   {
    SceneManager.LoadScene("Kingdom3");

   }

}
