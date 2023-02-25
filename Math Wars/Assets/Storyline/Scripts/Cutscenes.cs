using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Cutscenes : MonoBehaviour
{

    [SerializeField]List<Sprite> cutsceneFrames = new List<Sprite>();
    [SerializeField]Image storyFrame;
    int cutsceneCount;
    void Start()
    {
        
        cutsceneCount = 0;
        storyFrame.sprite = cutsceneFrames[0];

    }

   public void NextFrame()
   {
    cutsceneCount++;
    if(cutsceneCount == cutsceneFrames.Count)
    {
        SceneManager.LoadScene("Story Mode Map");

    }
    else
    {
        storyFrame.sprite = cutsceneFrames[cutsceneCount];

    }
   }
}
