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
    [SerializeField]GameObject AdventureBack;
    [SerializeField]GameObject MathTownBack;
    [SerializeField]GameObject ArenaBack;
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
    
    MathTownTutorialCount++;
    MathTownBack.SetActive(true);    
    if (MathTownTutorialCount == 8)
    {
        CloseTutorial(); 
    }
    else
    {
        MathTownHelpImage.sprite = MathTownHelpImages[MathTownTutorialCount];     
    }

}

   public void NextTutorialArena()
{
    
    ArenaTutorialCount++;
    ArenaBack.SetActive(true);    
    if (ArenaTutorialCount == 9)
    {
        CloseTutorial();
    }
     else
    {
        ArenaHelpImage.sprite = ArenaHelpImages[ArenaTutorialCount];     
    }

}

   public void NextTutorialStory()
{
    
    StoryTutorialCount++;
    AdventureBack.SetActive(true);    
    if (StoryTutorialCount == 10)
    {
        CloseTutorial();
    }
    else
    {
        StoryHelpImage.sprite = StoryHelpImages[StoryTutorialCount];     
    }
}

public void BackTutorialMathTown()
{
    
    MathTownTutorialCount--;
    if (MathTownTutorialCount == 0)
    {
        MathTownBack.SetActive(false);    
    }
        MathTownHelpImage.sprite = MathTownHelpImages[MathTownTutorialCount];     
}

public void BackutorialArena()
{
    
    ArenaTutorialCount--;
    if (ArenaTutorialCount == 0)
    {
        ArenaBack.SetActive(false);    
    }

        ArenaHelpImage.sprite = ArenaHelpImages[ArenaTutorialCount];     


}

public void BackTutorialStory()
{
    
    StoryTutorialCount--;
    if (StoryTutorialCount == 0)
    {
        AdventureBack.SetActive(false);    
    }

        StoryHelpImage.sprite = StoryHelpImages[StoryTutorialCount];     

}


public void CloseTutorial()
{
    StoryTutorial.SetActive(false);
    ArenaTutorial.SetActive(false);
    MathTownTutorial.SetActive(false);
    helpPopUp.SetActive(false);    
    settingsPopUp.SetActive(true);    

}
}
