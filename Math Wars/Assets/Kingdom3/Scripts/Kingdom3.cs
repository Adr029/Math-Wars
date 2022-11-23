using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Kingdom3 : MonoBehaviour
{
    public int level = 1;
    Scene currentScene;
    string sceneName;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;
    public string selectedLevel;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        level = PlayerPrefs.GetInt("kingdom3Level");
        Debug.Log(level);

         switch (level)
        {

            case 1:
                button2.interactable = true;
            break;

            case 2:
                button2.interactable = true;
                button3.interactable = true;
            break;

            case 3:
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
            break;

            case 4:
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
                button5.interactable = true;
            break;

            case 5:
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
                button5.interactable = true;
                button6.interactable = true;
            break;

            case 6:
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
                button5.interactable = true;
                button6.interactable = true;
                button7.interactable = true;
            break;

            case 7:
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
                button5.interactable = true;
                button6.interactable = true;
                button7.interactable = true;
                button8.interactable = true;
            break;
            
            case 8:
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
                button5.interactable = true;
                button6.interactable = true;
                button7.interactable = true;
                button8.interactable = true;
                button9.interactable = true;
            break;

            case 9:
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
                button5.interactable = true;
                button6.interactable = true;
                button7.interactable = true;
                button8.interactable = true;
                button9.interactable = true;
                button10.interactable = true;
            break;
             case 10:
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
                button5.interactable = true;
                button6.interactable = true;
                button7.interactable = true;
                button8.interactable = true;
                button9.interactable = true;
                button10.interactable = true;
                button11.interactable = true;
            break;
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
