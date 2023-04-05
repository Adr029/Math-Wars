using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewArenaAudio : MonoBehaviour
{

    int playAudio;
    int playSFX;
    [SerializeField]AudioSource BGMusic;
    [SerializeField]AudioSource Manager;
    [SerializeField]GameObject BattleManagement;
    public List <AudioClip> AttackSFX;
    [SerializeField] AudioSource uiSFX;
    [SerializeField] AudioSource answerSFX;
    BattleNew battle;
    int playerWeapon;

    void Start()
    {

        battle = BattleManagement.GetComponent<BattleNew>();    
        playerWeapon = battle.playerClone.GetComponent<PlayerUnit>().weaponSprite;
        Debug.Log(playerWeapon);
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
     
}
