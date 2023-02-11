using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    int playAudio;
    int playSFX;
    [SerializeField]AudioSource BGMusic;
    [SerializeField]AudioSource uiSFX;

    void Start()
    {

        if(playAudio == 1)
        {
           BGMusic.Play();
        } 
    }
    void Update()
    {
        playAudio = PlayerPrefs.GetInt("music", 1);
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
        playSFX = PlayerPrefs.GetInt("SFX");

        if (playSFX == 1)
        {
            uiSFX.Play();
        }
    }
}
