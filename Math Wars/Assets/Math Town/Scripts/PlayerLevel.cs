using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    public int experience;
    public Text level;
    [SerializeField]Slider PlayerXP;

    int requiredXP = 100;

    public int playerLevel;

    void Start()
    {
        
        experience =  PlayerPrefs.GetInt("XP", 0);
        playerLevel = PlayerPrefs.GetInt("Level", 1);
        PlayerPrefs.SetInt("Level", playerLevel);
        PlayerPrefs.SetInt("XP", experience);
        computeLevel();
        level.text =  playerLevel.ToString();
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
            level.text =  playerLevel.ToString();
        }

    }
 
}
