using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class KingdomManager : MonoBehaviour
{
    public int level = 1;
    string kingdomName;
    public List<Button> levels = new List<Button>();
    public List<Sprite> bgOptions = new List<Sprite>();
    public List<Sprite> bossOptions = new List<Sprite>();
    public Sprite unlocked;
    public SpriteRenderer background;
    public Button bossBattle;
    [SerializeField]GameObject Transition;
    public Image img;

    public Animator animate;

    public string selectedLevel;
void Awake() 
{
    Transition.SetActive(true);
 
}
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

        if (level >= 1)
        {
            levels[0].interactable = true;
            levels[0].GetComponent<Image>().sprite = unlocked;
        }
         if (level >= 2)
        {
            levels[1].interactable = true;
            levels[1].GetComponent<Image>().sprite = unlocked;
        }
         if (level >= 3)
        {
            levels[2].interactable = true;
            levels[2].GetComponent<Image>().sprite = unlocked;
        }
         if (level >= 4)
        {
            levels[3].interactable = true;
            levels[3].GetComponent<Image>().sprite = unlocked;
        }
         if (level >= 5)
        {
            levels[4].interactable = true;
        }
        
    }
    public void BeginBattle(Button button)
    {
        selectedLevel = button.name;
        PlayerPrefs.SetString("storyKingdom", kingdomName);
        PlayerPrefs.SetString("selectedLevel", selectedLevel);
        StartCoroutine(FadeBattle());

    }

    IEnumerator FadeBattle()
    {
        animate.SetBool("Fade", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene("Arena");

    }
}
