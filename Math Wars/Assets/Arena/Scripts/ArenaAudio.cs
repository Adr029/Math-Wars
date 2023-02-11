using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaAudio : MonoBehaviour
{

    int playAudio;
    int playSFX;
    [SerializeField]AudioSource BGMusic;
    [SerializeField]AudioSource Manager;
    [SerializeField]GameObject BattleManagement;

    public List <AudioClip> EnemyAttack;
    [SerializeField] AudioClip EnemyHeal;
    [SerializeField] AudioClip PlayerAttack;
    int EnemyIndex;
    BattleManager battle;
    
    AudioClip enemyAttack;

    void Start()
    {
        battle = BattleManagement.GetComponent<BattleManager>();    
        EnemyIndex = battle.prefabIndex;
    }
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
            Manager.clip = PlayerAttack;
            Manager.Play();
        }
    }
    public void PlayPlayerHeal()
    {
        if (playSFX == 1)
            {
                Manager.clip = EnemyHeal;
                Manager.Play();
            }
    }
    public void PlayEnemyAttack()
    {
        if (playSFX == 1)
            {
                switch (EnemyIndex)
                {
                    case 0:
                            enemyAttack = EnemyAttack[0];
                            Manager.clip = enemyAttack;
                            Manager.Play();
                    break;
                    case 1:
                            enemyAttack = EnemyAttack[1];
                            Manager.clip = enemyAttack;
                            Manager.Play();
                    break;
            }
                }
                
    }
    public void PlayEnemyHeal()
    {
        if (playSFX == 1)
            {
                Manager.clip = EnemyHeal;
                Manager.Play();
            }
    }
    public void MatchEnding()
    {

    }
}
