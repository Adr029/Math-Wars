using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Kingdom1: MonoBehaviour
{
    public int level = 1;
    Scene currentScene;
    string sceneName;
   
    public List<Button> levels = new List<Button>();

    public string selectedLevel;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
       
        level = PlayerPrefs.GetInt("kingdom1Level");

        if (level >= 1)
        {
            levels[1].interactable = true;

        }
         if (level >= 2)
        {
            levels[2].interactable = true;

        }
         if (level >= 3)
        {
            levels[3].interactable = true;

        }
         if (level >= 4)
        {
            levels[4].interactable = true;

        }
         if (level >= 5)
        {
            levels[5].interactable = true;

        }
         if (level >= 6)
        {
            levels[6].interactable = true;

        }
         if (level >= 7)
        {
            levels[7].interactable = true;

        }
         if (level >= 8)
        {
            levels[8].interactable = true;

        }
         if (level >= 9)
        {
            levels[9].interactable = true;

        }
         if (level >= 10)
        {
            levels[10].interactable = true;

        }
        
    }
    public void BeginBattle(Button button)
    {
        selectedLevel = button.name;
        SceneManager.LoadScene("StoryArena");
        PlayerPrefs.SetString("storyKingdom", sceneName);
        PlayerPrefs.SetString("selectedLevel", selectedLevel);
    }


}
