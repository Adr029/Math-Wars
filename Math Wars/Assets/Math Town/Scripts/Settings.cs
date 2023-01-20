using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    [SerializeField] Button musicToggle;
    [SerializeField] Button SFXToggle;
    int music;
    int SFX;
    void Start()
    {
        music = PlayerPrefs.GetInt("music", 1);
        SFX = PlayerPrefs.GetInt("SFX", 1);
    if (music == 1)
    {
        musicToggle.GetComponentInChildren<Text>().text = "ON";
    }
    else if (music == 0)
    {
        musicToggle.GetComponentInChildren<Text>().text = "OFF";
    }
    if (SFX == 1)
    {
        SFXToggle.GetComponentInChildren<Text>().text = "ON";
    }
    else if (music == 0)
    {
        SFXToggle.GetComponentInChildren<Text>().text = "OFF";
    }
    }
   public void ToggleMusic()
   {
    music = PlayerPrefs.GetInt("music");
    if (music == 1)
    {
        PlayerPrefs.SetInt("music", 0);
        musicToggle.GetComponentInChildren<Text>().text = "OFF";

    }
    else if (music == 0)
    {
        PlayerPrefs.SetInt("music", 1);
        musicToggle.GetComponentInChildren<Text>().text = "ON";
    }
   }
   public void ToggleSFX()
   {
    SFX = PlayerPrefs.GetInt("SFX");
    if (SFX == 1)
    {
        PlayerPrefs.SetInt("SFX", 0);
        SFXToggle.GetComponentInChildren<Text>().text = "OFF";
    }
    else if (music == 0)
    {
        PlayerPrefs.SetInt("SFX", 1);
        SFXToggle.GetComponentInChildren<Text>().text = "ON";
    }
   }
}
