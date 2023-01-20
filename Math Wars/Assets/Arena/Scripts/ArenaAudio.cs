using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaAudio : MonoBehaviour
{

    int playAudio;
    int playSFX;
    [SerializeField]AudioSource BGMusic;
    [SerializeField]AudioSource PlayerAttack;
    [SerializeField]AudioSource PlayerHeal;
    [SerializeField]AudioSource EnemyAttack;
    [SerializeField]AudioSource EnemyHeal;

    void Update()
    {
        playAudio = PlayerPrefs.GetInt("music", 1);
        playSFX = PlayerPrefs.GetInt("SFX", 1);
    }

    public void PlayBG()
    {
        if (playAudio == 1)
        {
            BGMusic.Play();
        }
    }
    public void PlayPlayerAttack()
    {
        if (playSFX == 1)
        {
            PlayerAttack.Play();
        }
    }
    public void PlayPlayerHeal()
    {
        if (playSFX == 1)
            {
                PlayerHeal.Play();
            }
    }
    public void PlayEnemyAttack()
    {
        if (playSFX == 1)
            {
                EnemyAttack.Play();
            }
    }
    public void PlayEnemyHeal()
    {
        if (playSFX == 1)
            {
                EnemyHeal.Play();
            }
    }
    public void MatchEnding()
    {

    }
}
