using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    int playAudio;
    // Start is called before the first frame update
    [SerializeField]AudioSource BGMusic;

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
}
