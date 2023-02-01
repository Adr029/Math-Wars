using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    [SerializeField] Button musicToggle;
    [SerializeField] Button SFXToggle;
    [SerializeField] GameObject creditsPopUp;
    [SerializeField]GameObject helpPopUp;
    //[SerializeField]Image MathTownHelpImage;
    //public List<Sprite> MathTownHelpImages = new List<Sprite>();
    //[SerializeField]Image ArenaHelpImage;
    //public List<Sprite> ArenaHelpImages = new List<Sprite>();
    //[SerializeField]Image StoryModeHelpImage;
    //public List<Sprite> StoryModeHelpImages = new List<Sprite>();

    //[SerializeField]GameObject MathTownTutorial;
    //[SerializeField]GameObject ArenaTutorial;
    //[SerializeField]GameObject StoryTutorial;

    //public int MathTownTutorialCount;
    //public int ArenaTutorialCount;
    //public int StoryTutorialCount;


    int music;
    int SFX;
    void Start()
    {
        music = PlayerPrefs.GetInt("music", 1);
        SFX = PlayerPrefs.GetInt("SFX", 1);
    if (music == 1)
    {
        musicToggle.GetComponentInChildren<Text>().text = "ON";
    }
    else if (music == 0)
    {
        musicToggle.GetComponentInChildren<Text>().text = "OFF";
    }
    if (SFX == 1)
    {
        SFXToggle.GetComponentInChildren<Text>().text = "ON";
    }
    else if (music == 0)
    {
        SFXToggle.GetComponentInChildren<Text>().text = "OFF";
    }
    }
   public void ToggleMusic()
   {
    music = PlayerPrefs.GetInt("music");
    if (music == 1)
    {
        PlayerPrefs.SetInt("music", 0);
        musicToggle.GetComponentInChildren<Text>().text = "OFF";

    }
    else if (music == 0)
    {
        PlayerPrefs.SetInt("music", 1);
        musicToggle.GetComponentInChildren<Text>().text = "ON";
    }
   }
   public void ToggleSFX()
   {
    SFX = PlayerPrefs.GetInt("SFX");
    if (SFX == 1)
    {
        PlayerPrefs.SetInt("SFX", 0);
        SFXToggle.GetComponentInChildren<Text>().text = "OFF";
    }
    else if (music == 0)
    {
        PlayerPrefs.SetInt("SFX", 1);
        SFXToggle.GetComponentInChildren<Text>().text = "ON";
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
   }
   public void CloseCredits()
   {
        creditsPopUp.SetActive(false);
   }
public void ShowTutorialMathTown()
{
    //MathTownTutorial.SetActive(true);
    //MathTownTutorialCount = 0;
    //MathTownHelpImage.sprite = MathTownHelpImages[0];    
}
public void ShowTutorialArena()
{
    //ArenaTutorial.SetActive(true);
    //ArenaTutorialCount = 0;
    //ArenaHelpImage.sprite = ArenaHelpImages[0];    
}
public void ShowTutorialStory()
{
    //StoryTutorial.SetActive(true);
    //StoryTutorialCount = 0;
    //StoryHelpImage.sprite = StoryHelpImages[0];    
}
   /*public void NextTutorialMathTown()
{
    
        MathTownTutorialCount = MathTownTutorialCount + 1;
     
        if (MathTownTutorialCount == 1)
        {
            //MathTownHelpImage.sprite = MathTownHelpImages[1];
        }
        else if (MathTownTutorialCount == 2)
        {
            //MathTownHelpImage.sprite = MathTownHelpImages[2];
        }
        else if (MathTownTutorialCount == 3)
        {
            //MathTownHelpImage.sprite = MathTownHelpImages[3];
        }
    
    if (MathTownTutorialCount == 4)
    {
        CloseTutorial(); 
    }

    //insert code for changing button from next to exit
}
*/
   /*public void NextTutorialArena()
{
    
        ArenaTutorialCount = ArenaTutorialCount + 1;
     
        if (ArenaTutorialCount == 1)
        {
            //ArenaHelpImage.sprite = ArenaHelpImages[1];
        }
        else if (ArenaTutorialCount == 2)
        {
            //ArenaHelpImage.sprite = ArenaHelpImages[2];
        }
        else if (ArenaTutorialCount == 3)
        {
            //ArenaHelpImage.sprite = ArenaHelpImages[3];
        }
    
    if (ArenaTutorialCount == 4)
    {
        CloseTutorial(); 
    }

    //insert code for changing button from next to exit
}
*/
   /*public void NextTutorialStory()
{
    
        StoryModeTutorialCount = StoryModeTutorialCount + 1;
     
        if (StoryModeTutorialCount == 1)
        {
            //StoryModeHelpImage.sprite = StoryModeHelpImages[1];
        }
        else if (StoryModeTutorialCount == 2)
        {
            //StoryModeHelpImage.sprite = StoryModeHelpImages[2];
        }
        else if (StoryModeTutorialCount == 3)
        {
            //StoryModeHelpImage.sprite = StoryModeHelpImages[3];
        }
    
    if (StoryModeTutorialCount == 4)
    {
        CloseTutorial(); 
    }

    //insert code for changing button from next to exit
}
*/


public void CloseTutorial()
{
    //StoryTutorial.SetActive(false);
    //ArenaTutorial.SetActive(false);
    //MathTownTutorial.SetActive(false);
}
}