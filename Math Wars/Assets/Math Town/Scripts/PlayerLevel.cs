using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    public int experience;
    public Text level;
    public Text XP;
    [SerializeField]Slider PlayerXP;

    int requiredXP = 100;

    public int playerLevel;

void Awake() {
    computeLevel();

    }
    void Start()
    {
        experience =  PlayerPrefs.GetInt("XP");
        playerLevel = PlayerPrefs.GetInt("Level");
        level.text =  playerLevel.ToString();
        //XP.text =     experience.ToString()+ "/100";        
        computeLevel();
        PlayerXP.value = experience;

    }

    public void computeLevel()
    {

        if (experience >= requiredXP)
        {
            playerLevel++;
            experience -= requiredXP;
            PlayerPrefs.SetInt("Level", playerLevel);
            PlayerPrefs.SetInt("XP", experience);
        }

    }
 
}
