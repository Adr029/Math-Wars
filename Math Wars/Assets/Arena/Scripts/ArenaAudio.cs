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
    [SerializeField] AudioClip MatchWin;
    [SerializeField] AudioClip MatchLose;
    public List <AudioClip> EnemyHurt;
    public List <AudioClip> AttackSFX;
    [SerializeField] AudioSource uiSFX;
    [SerializeField] AudioSource hurtSFX;
    [SerializeField] AudioSource answerSFX;
    [SerializeField] AudioSource enemySFX;
    [SerializeField] AudioSource armySFX;
    int EnemyIndex;
    BattleManager battle;
    AudioClip enemyAttack;
    int playerWeapon;

    void Start()
    {
        battle = BattleManagement.GetComponent<BattleManager>();    
        EnemyIndex = battle.prefabIndex;
        playerWeapon = battle.playerClone.GetComponent<PlayerUnit>().weaponSprite;
        
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
            switch (playerWeapon)
        {
        //0 fireball, 1 crop, 2 water, 3 thunder
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
            Manager.clip = AttackSFX[0];
            Manager.Play();
        break;
        case 5:
            Manager.clip = AttackSFX[1];
            Manager.Play();
        break;
        case 6:
            Manager.clip = AttackSFX[2];
            Manager.Play();
        break;
        case 7:
            Manager.clip = AttackSFX[3];
            Manager.Play();
        break;
    
        }
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
    public void PlayHurt()
    {
        if (playSFX == 1)
            {
                int hurt = Random.Range(0,6);
                switch (hurt)
                {
                    case 0:
                        hurtSFX.clip = EnemyHurt[0];
                    break;
                    case 1:
                        hurtSFX.clip = EnemyHurt[1];
                    break;
                    case 2:
                        hurtSFX.clip = EnemyHurt[2];
                    break;
                    case 3:
                        hurtSFX.clip = EnemyHurt[3];
                    break;
                    case 4:
                        hurtSFX.clip = EnemyHurt[4];
                    break;
                    case 5:
                        hurtSFX.clip = EnemyHurt[5];
                    break;

                }
                    hurtSFX.Play();

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
                    case 2:
                            enemyAttack = EnemyAttack[2];
                            enemySFX.clip = enemyAttack;
                            enemySFX.Play();
                    break;
                    case 3:
                            enemyAttack = EnemyAttack[3];
                            enemySFX.clip = enemyAttack;
                            enemySFX.Play();
                    break;
                    case 4:
                    case 5:
                    case 6:
                            enemyAttack = EnemyAttack[4];
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
    public void PlayMatchLose()
    {
        if (playAudio == 1)
        {
            BGMusic.volume = 0f;

            Manager.clip = MatchLose;
            Manager.Play();
        }
    }
    public void PlayMatchWin()
    {
        if (playAudio == 1)
        {
            BGMusic.volume = 0f;

            Manager.clip = MatchWin;
            Manager.Play();
        }
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

        if (playSFX == 1)
        {
            uiSFX.Play();
        }
    }
      public void PlayAnswerSFX()
    {

        if (playSFX == 1)
        {
            answerSFX.Play();
        }
    }
      public void PlayArmySFX()
    {
            //consider randomizing army sfx parang sa ginawa sa hurt
        if (playSFX == 1)
        {
            armySFX.Play();
        }
    }
}
