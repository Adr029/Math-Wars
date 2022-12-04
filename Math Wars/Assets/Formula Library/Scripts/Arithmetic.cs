using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arithmetic : MonoBehaviour
{

public List<Sprite> formula = new List<Sprite>();
public SpriteRenderer arithmeticFormula;
 public void Addition()
 {
    arithmeticFormula.sprite = formula[0];
 }

 public void Multiplication()
 {
    arithmeticFormula.sprite = formula[1];
 }

}
