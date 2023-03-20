using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algebra : MonoBehaviour
{
    // Start is called before the first frame update
public List<Sprite> formula = new List<Sprite>();
public SpriteRenderer algebraFormula;
int AlgebraPageCount;
[SerializeField]GameObject algebraNextPageButton;
[SerializeField]GameObject algebraBackPageButton;

void Start() 
{
    algebraFormula.sprite = formula[0];
    AlgebraPageCount = 0;    
    algebraBackPageButton.SetActive(false);
}

 public void NextAlgebraPage()
{    
        AlgebraPageCount = AlgebraPageCount + 1;
     
        if (AlgebraPageCount == 0)
        {
            algebraFormula.sprite = formula[0];            
            algebraNextPageButton.SetActive(true);
            algebraBackPageButton.SetActive(false);
        }
        else if (AlgebraPageCount == 1)
        {
            algebraFormula.sprite = formula[1];            
            algebraBackPageButton.SetActive(true);
            algebraNextPageButton.SetActive(true);
        }
        else if (AlgebraPageCount == 2)
        {
            algebraFormula.sprite = formula[2];
            algebraBackPageButton.SetActive(true);
            algebraNextPageButton.SetActive(false);
        }
}
 public void BackAlgebraPage()
{    
        AlgebraPageCount = AlgebraPageCount - 1;
     
        if (AlgebraPageCount == 2)
        {
            algebraFormula.sprite = formula[2];
            algebraBackPageButton.SetActive(true);
            algebraNextPageButton.SetActive(true);
        }
        else if (AlgebraPageCount == 1)
        {
            algebraFormula.sprite = formula[1];            
            algebraBackPageButton.SetActive(true);
            algebraNextPageButton.SetActive(true);
        }
        else if (AlgebraPageCount == 0)
        {
            algebraFormula.sprite = formula[0];            
            algebraNextPageButton.SetActive(true);
            algebraBackPageButton.SetActive(false);
        }
}

 public void ResetAlge()
 {
    algebraFormula.sprite = formula[0];
    AlgebraPageCount = 0;  
    algebraBackPageButton.SetActive(false);
    algebraNextPageButton.SetActive(true);
 }
}