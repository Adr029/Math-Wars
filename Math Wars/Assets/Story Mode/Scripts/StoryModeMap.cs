using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryModeMap : MonoBehaviour
{

public string kingdomName;
   public void Kingdom1()
   {
    kingdomName = "Kingdom1";    
    PlayerPrefs.SetString("kingdomName", kingdomName);
    SceneManager.LoadScene("Kingdom");

   }

  public void Kingdom2()
   {
    kingdomName = "Kingdom2";    
    PlayerPrefs.SetString("kingdomName", kingdomName);
    SceneManager.LoadScene("Kingdom");

   }

   public void Kingdom3()
   {
    kingdomName = "Kingdom3";    
    PlayerPrefs.SetString("kingdomName", kingdomName);
    SceneManager.LoadScene("Kingdom");

   }

}
