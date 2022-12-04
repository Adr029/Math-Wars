using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class KingdomManager : MonoBehaviour
{
    public int level = 1;
    Scene currentScene;
    string kingdomName;
    public List<Button> levels = new List<Button>();
    public List<Sprite> bgOptions = new List<Sprite>();
    public List<Sprite> bossOptions = new List<Sprite>();
    public SpriteRenderer background;
    public Button bossBattle;

    public string selectedLevel;

    void Start()
    {
       kingdomName = PlayerPrefs.GetString("kingdomName");

        switch (kingdomName)
        {
            case "Kingdom1":
                level = PlayerPrefs.GetInt("kingdom1Level");
                background.sprite = bgOptions[0];
                bossBattle.GetComponent<Image>().sprite = bossOptions[0];
            break;
            
            case "Kingdom2":
                level = PlayerPrefs.GetInt("kingdom2Level");
                background.sprite = bgOptions[1];
                bossBattle.GetComponent<Image>().sprite = bossOptions[1];

            break;

            case "Kingdom3":
                level = PlayerPrefs.GetInt("kingdom3Level");
                background.sprite = bgOptions[2];
                bossBattle.GetComponent<Image>().sprite = bossOptions[2];

            break;

        }
        Debug.Log(level);

        if (level >= 1)
        {
            levels[0].interactable = true;

        }
         if (level >= 2)
        {
            levels[1].interactable = true;

        }
         if (level >= 3)
        {
            levels[2].interactable = true;

        }
         if (level >= 4)
        {
            levels[3].interactable = true;

        }
         if (level >= 5)
        {
            levels[4].interactable = true;

        }
        
    }
    public void BeginBattle(Button button)
    {
        selectedLevel = button.name;
        SceneManager.LoadScene("Arena");
        PlayerPrefs.SetString("storyKingdom", kingdomName);
        PlayerPrefs.SetString("selectedLevel", selectedLevel);
    }
}
