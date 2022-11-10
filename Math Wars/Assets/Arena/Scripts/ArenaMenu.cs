using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArenaMenu : MonoBehaviour
{
    //eto muna starting scene
public string difficulty;
[SerializeField]GameObject Menu;
[SerializeField]GameObject CombatUI;
[SerializeField]GameObject BattleManagement;
[SerializeField]Text StatusText;
[SerializeField]Text Wins;
public int winCount;

BattleManager battle;


// button onclick get name chuchu
void Start()
{
    winCount = PlayerPrefs.GetInt("wins");
    Wins.text = winCount.ToString() + " WINS";
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

    battle = BattleManagement.GetComponent<BattleManager>();
    battle.BeginBattle();
}
else
{
StatusText.text = "PLEASE SELECT DIFFICULTY";
}
}
}
