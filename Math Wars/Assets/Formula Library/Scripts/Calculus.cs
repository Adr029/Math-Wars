using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculus : MonoBehaviour
{
    public List<Sprite> formula = new List<Sprite>();
    public SpriteRenderer calculusFormula;
private void Start() 
{

   calculusFormula.sprite = formula[0];

}
 public void DifferentiationRules()
 {
    calculusFormula.sprite = formula[1];
 }
 
 public void DiffTrigo()
 {
    calculusFormula.sprite = formula[2];
 }
 
 public void DiffInverseTrigo()
 {
    calculusFormula.sprite = formula[3];  
 }

 public void DiffLogarithmic()
 {
    calculusFormula.sprite = formula[4];
 }
 
 public void DiffExponential()
 {
    calculusFormula.sprite = formula[5];
 }

 public void ResetCalc()
 {
   calculusFormula.sprite = formula[0];

 }
}
