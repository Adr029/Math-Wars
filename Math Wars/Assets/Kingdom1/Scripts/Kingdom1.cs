using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kingdom1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void BeginBattle()
    {
        SceneManager.LoadScene("StoryArena");
    }
}
