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
    [SerializeField] AudioClip BossWin;
    [SerializeField] AudioClip PlayerAttack;
    public List <AudioClip> EnemyHurt;
    [SerializeField] AudioSource uiSFX;
    [SerializeField] AudioSource enemySFX;
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
        if(playAudio == 1)
        {
           BGMusic.UnPause();
        }
        if(playAudio == 0)
        {
           BGMusic.Pause();
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
                enemySFX.clip = EnemyHeal;
                enemySFX.Play();
            }
    }
    public void PlayEnemyHurt()
    {
        if (playSFX == 1)
            {
                int hurt = Random.Range(0,7);
                switch (hurt)
                {
                    case 0:
                        enemySFX.clip = EnemyHurt[0];
                    break;
                    case 1:
                        enemySFX.clip = EnemyHurt[1];
                    break;
                    case 2:
                        enemySFX.clip = EnemyHurt[2];
                    break;
                    case 3:
                        enemySFX.clip = EnemyHurt[3];
                    break;
                    case 4:
                        enemySFX.clip = EnemyHurt[4];
                    break;
                    case 5:
                        enemySFX.clip = EnemyHurt[5];
                    break;
                    case 6:
                        enemySFX.clip = EnemyHurt[6];
                    break;
                }
                    enemySFX.Play();

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
                            enemySFX.clip = enemyAttack;
                            enemySFX.Play();
                    break;
                    case 1:
                            enemyAttack = EnemyAttack[1];
                            enemySFX.clip = enemyAttack;
                            enemySFX.Play();
                    break;
            }
                }
                
    }
    public void PlayEnemyHeal()
    {
        if (playSFX == 1)
            {
                enemySFX.clip = EnemyHeal;
                enemySFX.Play();
            }
    }
    public void MatchEnding()
    {
        
    }
    public void BossFightWin()
    {
        if (playAudio == 1)
        {
            BGMusic.volume = 0f;

            Manager.clip = BossWin;
            Manager.Play();
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
