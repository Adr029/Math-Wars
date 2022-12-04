using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculus : MonoBehaviour
{
    public List<Sprite> formula = new List<Sprite>();
    public SpriteRenderer calculusFormula;
    // Start is called before the first frame update
 public void DifferentiationRules()
 {
    calculusFormula.sprite = formula[0];
 }
 
 public void DiffTrigo()
 {
    calculusFormula.sprite = formula[1];
 }
 
 public void DiffInverseTrigo()
 {
    calculusFormula.sprite = formula[2];  
 }

 public void DiffLogarithmic()
 {
    calculusFormula.sprite = formula[3];
 }
 
 public void DiffExponential()
 {
    calculusFormula.sprite = formula[4];
 }
 
 public void IntegrationRules()
 {
    calculusFormula.sprite = formula[5];
 }
 
 public void IntegLog()
 {
    calculusFormula.sprite = formula[6];
 }
 
 public void IntegExponential()
 {
  calculusFormula.sprite = formula[7];  
 }
 
 public void IntegTrigonometric()
 {
    calculusFormula.sprite = formula[8];
 }
  public void IntegralsOtherTrigo()
 {
    calculusFormula.sprite = formula[9];
 }
 public void IntegInverseTrigo()
 {
    calculusFormula.sprite = formula[10];
 }

}
