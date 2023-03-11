using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingdomAudio : MonoBehaviour
{
    private static KingdomAudio backgroundMusic;

    int playAudio;
    int playSFX;
    [SerializeField]AudioSource BGMusic;
   
    
    void Awake()
    {
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }

    }
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

}
