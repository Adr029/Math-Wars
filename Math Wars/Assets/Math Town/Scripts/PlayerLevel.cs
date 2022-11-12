using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int experience;

    int requiredXP = 100;

    public int playerLevel;
    void Start()
    {
        experience = PlayerPrefs.GetInt("XP");
        playerLevel = PlayerPrefs.GetInt("Level");
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
