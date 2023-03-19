using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculus : MonoBehaviour
{
    public List<Sprite> formula = new List<Sprite>();
    public SpriteRenderer calculusFormula;
    int CalPageCount;
   [SerializeField]GameObject calNextPageButton;
   [SerializeField]GameObject calBackPageButton;
private void Start() 
{

   calculusFormula.sprite = formula[0];
   CalPageCount = 0;    
   calBackPageButton.SetActive(false);
}
 
public void NextCalPage()
{    
        CalPageCount = CalPageCount + 1;
     
        if (CalPageCount == 0)
        {
            calculusFormula.sprite = formula[0];            
            calNextPageButton.SetActive(true);
            calBackPageButton.SetActive(false);
        }
        else if (CalPageCount == 1)
        {
            calculusFormula.sprite = formula[1];            
            calBackPageButton.SetActive(true);
        }
        else if (CalPageCount == 2)
        {
            calculusFormula.sprite = formula[2];            
            calBackPageButton.SetActive(true);
        }
        else if (CalPageCount == 3)
        {
            calculusFormula.sprite = formula[3];
            calBackPageButton.SetActive(true);
            calNextPageButton.SetActive(false);
        }
}
 public void BackCalPage()
{    
        CalPageCount = CalPageCount - 1;
     
        if (CalPageCount == 3)
        {
            calculusFormula.sprite = formula[3];
            calBackPageButton.SetActive(true);
            calNextPageButton.SetActive(true);
        }
        else if (CalPageCount == 2)
        {
            calculusFormula.sprite = formula[2];            
            calBackPageButton.SetActive(true);
            calNextPageButton.SetActive(true);
        }
        else if (CalPageCount == 1)
        {
            calculusFormula.sprite = formula[1];            
            calBackPageButton.SetActive(true);
            calNextPageButton.SetActive(true);
        }
        else if (CalPageCount == 0)
        {
            calculusFormula.sprite = formula[0];            
            calNextPageButton.SetActive(true);
            calBackPageButton.SetActive(false);
        }
}


 public void ResetCalc()
 {
   calculusFormula.sprite = formula[0];
   CalPageCount = 0;  
   calBackPageButton.SetActive(false);
   calNextPageButton.SetActive(true);
 }
}
