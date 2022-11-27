using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ArenaMenu : MonoBehaviour
{
public string difficulty;
[SerializeField]Text Wins;
[SerializeField]Text XP;
[SerializeField]Text Level;
[SerializeField]Button confirm;
public int winCount;
public int experience;
public int playerLevel;

BattleManager battle;

void Start()
{   
    experience = PlayerPrefs.GetInt("XP");
    winCount = PlayerPrefs.GetInt("wins");
    playerLevel = PlayerPrefs.GetInt("Level");
    Wins.text = winCount.ToString() + " WINS";
    XP.text = "XP: " + experience.ToString()+ "/100";
    Level.text = "Level "+ playerLevel.ToString();
}
public void ChooseDifficulty(Button button)
{
    difficulty = button.name;
    confirm.interactable = true;
}

public void Confirm()
{
if (difficulty.Length != 0)
{
    PlayerPrefs.SetString("difficulty", difficulty);
    SceneManager.LoadScene("Arena");
}
else
{

}
}
}
