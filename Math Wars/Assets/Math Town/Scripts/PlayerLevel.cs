using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    public int experience;
    public Text level;
    public Transform canvas;

    public List<GameObject> NewItems = new List<GameObject>();
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

            switch (playerLevel)
            {

                case 2:
                    Instantiate(NewItems[0], new Vector3(0,0,0), Quaternion.identity, canvas);
                break;
                case 3:
                    Instantiate(NewItems[1], new Vector3(0,0,0), Quaternion.identity, canvas);
                break;
                case 4:
                    Instantiate(NewItems[2], new Vector3(0,0,0), Quaternion.identity, canvas);
                break;
                case 5:
                    Instantiate(NewItems[3], new Vector3(0,0,0), Quaternion.identity, canvas);

                break;
  
            }
        }

    }
 
}
