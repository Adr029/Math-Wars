using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryDifficulty : MonoBehaviour
{
    //eto muna starting scene
public string difficulty;
[SerializeField]GameObject Menu;
[SerializeField]GameObject CombatUI;
[SerializeField]GameObject BattleManagement;
[SerializeField]Text StatusText;
[SerializeField]Text Wins;
[SerializeField]Text XP;
[SerializeField]Text Level;
public int winCount;
public int experience;
public int playerLevel;

StoryBattle battle;


// button onclick get name chuchu
void Start()
{   
    experience = PlayerPrefs.GetInt("XP");
    winCount = PlayerPrefs.GetInt("wins");
    playerLevel = PlayerPrefs.GetInt("Level");
    Wins.text = winCount.ToString() + " WINS";
    XP.text = "XP: " + experience.ToString()+ "/100";
    Level.text = "Level "+ playerLevel.ToString();
    // convert sa leveling system later on
}
public void ChooseDifficulty(Button button)
{
    difficulty = button.name;
}

public void Confirm()
{
if (difficulty.Length != 0)
{
    Menu.SetActive(false);
    CombatUI.SetActive(true);
    battle = BattleManagement.GetComponent<StoryBattle>();
    battle.BeginBattle();
}
else
{
StatusText.text = "PLEASE SELECT DIFFICULTY";
}
}
}
