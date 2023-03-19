using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigonometry : MonoBehaviour
{

public List<Sprite> formula = new List<Sprite>();
public SpriteRenderer trigonometryFormula;
int TrigoPageCount;
[SerializeField]GameObject trigoNextPageButton;
[SerializeField]GameObject trigoBackPageButton;

void Start()
{
    trigonometryFormula.sprite = formula[0];
    TrigoPageCount = 0;    
    trigoBackPageButton.SetActive(false);
}

 public void NextTrigoPage()
{    
        TrigoPageCount = TrigoPageCount + 1;
     
        if (TrigoPageCount == 0)
        {
            trigonometryFormula.sprite = formula[0];            
            trigoNextPageButton.SetActive(true);
            trigoBackPageButton.SetActive(false);
        }
        else if (TrigoPageCount == 1)
        {
            trigonometryFormula.sprite = formula[1];            
            trigoBackPageButton.SetActive(true);
        }
        else if (TrigoPageCount == 2)
        {
            trigonometryFormula.sprite = formula[2];            
            trigoBackPageButton.SetActive(true);
        }
        else if (TrigoPageCount == 3)
        {
            trigonometryFormula.sprite = formula[3];
            trigoBackPageButton.SetActive(true);
            trigoNextPageButton.SetActive(false);
        }
}
 public void BackTrigoPage()
{    
        TrigoPageCount = TrigoPageCount - 1;
     
        if (TrigoPageCount == 3)
        {
            trigonometryFormula.sprite = formula[3];
            trigoBackPageButton.SetActive(true);
            trigoNextPageButton.SetActive(true);
        }
        else if (TrigoPageCount == 2)
        {
            trigonometryFormula.sprite = formula[2];            
            trigoBackPageButton.SetActive(true);
            trigoNextPageButton.SetActive(true);
        }
        else if (TrigoPageCount == 1)
        {
            trigonometryFormula.sprite = formula[1];            
            trigoBackPageButton.SetActive(true);
            trigoNextPageButton.SetActive(true);
        }
        else if (TrigoPageCount == 0)
        {
            trigonometryFormula.sprite = formula[0];            
            trigoNextPageButton.SetActive(true);
            trigoBackPageButton.SetActive(false);
        }
}

 public void ResetTrigo()
 {
    trigonometryFormula.sprite = formula[0];
    TrigoPageCount = 0;  
    trigoBackPageButton.SetActive(false);
    trigoNextPageButton.SetActive(true);
 }
}
