using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArenaSettings : MonoBehaviour
{
    [SerializeField] Image musicToggle;
    [SerializeField] Image SFXToggle;
    [SerializeField]GameObject settingsPopUp;
    [SerializeField]GameObject quitPopUp;
    [SerializeField]GameObject popUpBG;
    [SerializeField]CanvasGroup ArenaUI;
    public List<Sprite> soundIcon = new List<Sprite>();

    int music;
    int SFX;
void Awake()
    {
        music = PlayerPrefs.GetInt("music", 1);
        SFX = PlayerPrefs.GetInt("SFX", 1);
        
    if (music == 1)
    {
        musicToggle.sprite = soundIcon[1];
    }
    else if (music == 0)
    {
        musicToggle.sprite = soundIcon[0];
    }
    if (SFX == 1)
    {
        SFXToggle.sprite = soundIcon[1];
    }
    else if (music == 0)
    {
        SFXToggle.sprite = soundIcon[0];
    }
    }

    void Update()
    {
        
    }
public void OpenSettings()
{
    settingsPopUp.SetActive(true);
    ArenaUI.blocksRaycasts = false;
    popUpBG.SetActive(true);
}

public void CloseSettings()
{
    settingsPopUp.SetActive(false);
    ArenaUI.blocksRaycasts = true;
    popUpBG.SetActive(false);


}
public void OpenQuit()
{
    quitPopUp.SetActive(true);
    ArenaUI.blocksRaycasts = false;
    popUpBG.SetActive(true);
}

public void CloseQuit()
{
    quitPopUp.SetActive(false);
    ArenaUI.blocksRaycasts = true;
    popUpBG.SetActive(false);


}
public void ToggleMusic()
   {
    music = PlayerPrefs.GetInt("music", 1);
    if (music == 1)
    {
        PlayerPrefs.SetInt("music", 0);
        musicToggle.sprite = soundIcon[0];

    }
    else if (music == 0)
    {
        PlayerPrefs.SetInt("music", 1);
        musicToggle.sprite = soundIcon[1];
    }
   }
public void ToggleSFX()
   {
    SFX = PlayerPrefs.GetInt("SFX", 1);
    if (SFX == 1)
    {
        PlayerPrefs.SetInt("SFX", 0);
        SFXToggle.sprite = soundIcon[0];
    }
    else if (SFX == 0)
    {
        PlayerPrefs.SetInt("SFX", 1);
        SFXToggle.sprite = soundIcon[1];
    }
   }

}
