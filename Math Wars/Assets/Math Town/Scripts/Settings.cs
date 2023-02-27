using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    [SerializeField] Image musicToggle;
    [SerializeField] Image SFXToggle;
    [SerializeField] GameObject creditsPopUp;
    [SerializeField]GameObject helpPopUp;
    [SerializeField]GameObject settingsPopUp;
    public List<Sprite> soundIcon = new List<Sprite>();
[Header("Math Town Tutorial")]

    [SerializeField]Image MathTownHelpImage;
    public List<Sprite> MathTownHelpImages = new List<Sprite>();
    [SerializeField]GameObject MathTownTutorial;
    int MathTownTutorialCount;

    [Header("Arena Tutorial")]

    [SerializeField]Image ArenaHelpImage;
    public List<Sprite> ArenaHelpImages = new List<Sprite>();
    [SerializeField]GameObject ArenaTutorial;
    int ArenaTutorialCount;

    [Header("Story Tutorial")]

    [SerializeField]Image StoryHelpImage;
    public List<Sprite> StoryHelpImages = new List<Sprite>();
    [SerializeField]GameObject StoryTutorial;
    int StoryTutorialCount;


    int music;
    int SFX;
    void Start()
    {
        music = PlayerPrefs.GetInt("music", 1);
        SFX = PlayerPrefs.GetInt("SFX", 1);
        
    if (music == 1)
    {
        musicToggle.sprite = soundIcon[1];
    }
    else if (music == 0)
    {
        musicToggle.sprite = soundIcon[0];
    }
    if (SFX == 1)
    {
        SFXToggle.sprite = soundIcon[1];
    }
    else if (SFX == 0)
    {
        SFXToggle.sprite = soundIcon[0];
    }
    }
   public void ToggleMusic()
   {
    music = PlayerPrefs.GetInt("music", 1);
    if (music == 1)
    {
        PlayerPrefs.SetInt("music", 0);
        musicToggle.sprite = soundIcon[0];

    }
    else if (music == 0)
    {
        PlayerPrefs.SetInt("music", 1);
        musicToggle.sprite = soundIcon[1];
    }
   }
   public void ToggleSFX()
   {
    SFX = PlayerPrefs.GetInt("SFX", 1);
    if (SFX == 1)
    {
        PlayerPrefs.SetInt("SFX", 0);
        SFXToggle.sprite = soundIcon[0];
    }
    else if (SFX == 0)
    {
        PlayerPrefs.SetInt("SFX", 1);
        SFXToggle.sprite = soundIcon[1];
    }
   }

   public void showHelp()
   {
        helpPopUp.SetActive(true);
   }

    public void closeHelp()
    {
        helpPopUp.SetActive(false);
    }
   public void ShowCredits()
   {
        creditsPopUp.SetActive(true);
        settingsPopUp.SetActive(false);
   }
   public void CloseCredits()
   {
        creditsPopUp.SetActive(false);
        settingsPopUp.SetActive(true);
   }
public void ShowTutorialMathTown()
{
    MathTownTutorial.SetActive(true);
    MathTownTutorialCount = 0;
    MathTownHelpImage.sprite = MathTownHelpImages[0];
    settingsPopUp.SetActive(false);
    helpPopUp.SetActive(false);    
    
}
public void ShowTutorialArena()
{
    ArenaTutorial.SetActive(true);
    ArenaTutorialCount = 0;
    ArenaHelpImage.sprite = ArenaHelpImages[0];
    settingsPopUp.SetActive(false);
    helpPopUp.SetActive(false);    
    
    
}
public void ShowTutorialStory()
{
    StoryTutorial.SetActive(true);
    StoryTutorialCount = 0;
    StoryHelpImage.sprite = StoryHelpImages[0];
    settingsPopUp.SetActive(false);
    helpPopUp.SetActive(false);    
    
    
}
   public void NextTutorialMathTown()
{
    
        MathTownTutorialCount = MathTownTutorialCount + 1;
     
        if (MathTownTutorialCount == 1)
        {
            MathTownHelpImage.sprite = MathTownHelpImages[1];
        }
        else if (MathTownTutorialCount == 2)
        {
            MathTownHelpImage.sprite = MathTownHelpImages[2];
        }
        else if (MathTownTutorialCount == 3)
        {
            MathTownHelpImage.sprite = MathTownHelpImages[3];
        }
        else if (MathTownTutorialCount == 4)
        {
            MathTownHelpImage.sprite = MathTownHelpImages[4];
        }
        else if (MathTownTutorialCount == 5)
        {
            MathTownHelpImage.sprite = MathTownHelpImages[5];
        }
        else if (MathTownTutorialCount == 6)
        {
            MathTownHelpImage.sprite = MathTownHelpImages[6];
        }
        else if (MathTownTutorialCount == 7)
        {
            MathTownHelpImage.sprite = MathTownHelpImages[7];
        }
     
    
    if (MathTownTutorialCount == 8)
    {
        CloseTutorial(); 
    }

}

   public void NextTutorialArena()
{
    
        ArenaTutorialCount = ArenaTutorialCount + 1;
     
        if (ArenaTutorialCount == 1)
        {
            ArenaHelpImage.sprite = ArenaHelpImages[1];
        }
        else if (ArenaTutorialCount == 2)
        {
            ArenaHelpImage.sprite = ArenaHelpImages[2];
        }
        else if (ArenaTutorialCount == 3)
        {
            ArenaHelpImage.sprite = ArenaHelpImages[3];
        }
        else if (ArenaTutorialCount == 4)
        {
            ArenaHelpImage.sprite = ArenaHelpImages[4];
        }
        else if (ArenaTutorialCount == 5)
        {
            ArenaHelpImage.sprite = ArenaHelpImages[5];
        }
        else if (ArenaTutorialCount == 6)
        {
            ArenaHelpImage.sprite = ArenaHelpImages[6];
        }
        else if (ArenaTutorialCount == 7)
        {
            ArenaHelpImage.sprite = ArenaHelpImages[7];
        }
     
   
    if (ArenaTutorialCount == 8)
    {
        CloseTutorial();
    }

}

   public void NextTutorialStory()
{
    
         StoryTutorialCount = StoryTutorialCount + 1;
     
        if (StoryTutorialCount == 1)
        {
            StoryHelpImage.sprite = StoryHelpImages[1];
        }
        else if (StoryTutorialCount == 2)
        {
            StoryHelpImage.sprite = StoryHelpImages[2];
        }
        else if (StoryTutorialCount == 3)
        {
            StoryHelpImage.sprite = StoryHelpImages[3];
        }
        else if (StoryTutorialCount == 4)
        {
            StoryHelpImage.sprite = StoryHelpImages[4];
        }
        else if (StoryTutorialCount == 5)
        {
            StoryHelpImage.sprite = StoryHelpImages[5];
        }
        else if (StoryTutorialCount == 6)
        {
            StoryHelpImage.sprite = StoryHelpImages[6];
        }
        else if (StoryTutorialCount == 7)
        {
            StoryHelpImage.sprite = StoryHelpImages[7];
        }
     
   
    if (StoryTutorialCount == 8)
    {
        CloseTutorial();
    }

}


public void CloseTutorial()
{
    StoryTutorial.SetActive(false);
    ArenaTutorial.SetActive(false);
    MathTownTutorial.SetActive(false);
    settingsPopUp.SetActive(true);    
    helpPopUp.SetActive(true);    

}
}
