using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    public int experience;
    public Text level;
    public Text XP;

    int requiredXP = 100;

    public int playerLevel;
    void Start()
    {
        experience = PlayerPrefs.GetInt("XP");
        playerLevel = PlayerPrefs.GetInt("Level");
        level.text = "Level "+ playerLevel.ToString();
        XP.text = "XP: " + experience.ToString()+ "/100";        
        computeLevel();
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
