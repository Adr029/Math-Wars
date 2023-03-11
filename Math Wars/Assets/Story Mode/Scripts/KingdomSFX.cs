using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KingdomSFX : MonoBehaviour
{
    private static KingdomAudio backgroundMusic;

    int playAudio;
    int playSFX;
    [SerializeField]AudioSource uiSFX;
    [SerializeField]AudioSource uiSFXNonWood;
    [SerializeField]AudioClip mapSFX;
    

    void Start()
    {
        playAudio = PlayerPrefs.GetInt("music", 1);
        playSFX = PlayerPrefs.GetInt("SFX", 1);


    }
    void Update()
    {

        playAudio = PlayerPrefs.GetInt("music", 1);
        playSFX = PlayerPrefs.GetInt("SFX");
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
