using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathTownTutorial : MonoBehaviour
{
public List<Sprite> tutorialImages = new List<Sprite>();
public Image townTutorial;

int tutorialCount;

void Awake()
{
    townTutorial.sprite = tutorialImages[0];
}

public void NextTutorial()
{
    tutorialCount = tutorialCount + 1;

    if (tutorialCount == 1)
        {
            townTutorial.sprite = tutorialImages[1];
        }
        else if (tutorialCount == 2)
        {
            townTutorial.sprite = tutorialImages[2];
        }
        else if (tutorialCount == 3)
        {
            townTutorial.sprite = tutorialImages[3];
        }
   
        else if (tutorialCount == 4)
        {
            townTutorial.sprite = tutorialImages[4];
        }
   
        else if (tutorialCount == 5)
        {
            townTutorial.sprite = tutorialImages[5];
        }
   
        else if (tutorialCount == 6)
        {
            townTutorial.sprite = tutorialImages[6];
        }

    if (tutorialCount == 7)
    {
        Destroy(this.gameObject); 
    }
}
}
