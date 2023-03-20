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
    int firstPlaythrough;

    void Start()
    {
        firstPlaythrough = PlayerPrefs.GetInt("firstPlaythrough", 0);
        cutsceneCount = 0;
        storyFrame.sprite = cutsceneFrames[0];

    }

   public void NextFrame()
   {
    cutsceneCount++;
    if(cutsceneCount == cutsceneFrames.Count)
    {
        if (firstPlaythrough == 0)
        {
            SceneManager.LoadScene("Math Town");
            PlayerPrefs.SetInt("firstPlaythrough", 1);

        }
        else
        {
            SceneManager.LoadScene("Story Mode Map");
        }
    }
    else
    {
        storyFrame.sprite = cutsceneFrames[cutsceneCount];

    }
   }
    public void SkipStory(){
        SceneManager.LoadScene("Math Town");
        PlayerPrefs.SetInt("firstPlaythrough", 1);
    }

}
