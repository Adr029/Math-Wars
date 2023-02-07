using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigonometry : MonoBehaviour
{

public List<Sprite> formula = new List<Sprite>();
public SpriteRenderer trigonometryFormula;

public void Reciprocal()
{
    trigonometryFormula.sprite = formula[0];
}
public void Quotient()
{
    trigonometryFormula.sprite = formula[1];
}
public void Pythagorean()
{
    trigonometryFormula.sprite = formula[2];
}
public void SumandDifference()
{
    trigonometryFormula.sprite = formula[3];
}
public void DoubleAngle()
{
    trigonometryFormula.sprite = formula[4];
}
public void HalfAngle()
{
    trigonometryFormula.sprite = formula[5];
}

}
