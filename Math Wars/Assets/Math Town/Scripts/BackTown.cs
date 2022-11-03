using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BackTown : MonoBehaviour
{
   public void Back()
    {
        //StartCoroutine(Fade());
        SceneManager.LoadScene("Math Town");
    }
}
