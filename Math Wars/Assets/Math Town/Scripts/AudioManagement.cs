using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    int playAudio;
    int playSFX;
    [SerializeField]AudioSource BGMusic;
    [SerializeField]AudioSource uiSFX;
    [SerializeField]AudioSource uiSFXNonWood;
    [SerializeField]AudioClip mapSFX;
    void Start()
    {
        playAudio = PlayerPrefs.GetInt("music", 1);
        playSFX = PlayerPrefs.GetInt("SFX", 1);

        if(playAudio == 1)
        {
           BGMusic.Play();
        } 
    }
    void Update()
    {
        playAudio = PlayerPrefs.GetInt("music", 1);
        playSFX = PlayerPrefs.GetInt("SFX");

        if(playAudio == 1)
        {
           BGMusic.UnPause();
        }
        if(playAudio == 0)
        {
           BGMusic.Pause();
        }

    }

    public void PlayUISFX()
    {
        playSFX = PlayerPrefs.GetInt("SFX", 1);

        if (playSFX == 1)
        {
            uiSFX.Play();
        }
    }

    public void PlayUISFXNonWood()
    {
        playSFX = PlayerPrefs.GetInt("SFX", 1);

        if (playSFX == 1)
        {
            uiSFXNonWood.Play();
        }
    }
    
    public void PlayMapSFX()
    {
        playSFX = PlayerPrefs.GetInt("SFX", 1);

        if (playSFX == 1)
        {
            uiSFX.clip = mapSFX;
            uiSFX.Play();
        }
    }
}
