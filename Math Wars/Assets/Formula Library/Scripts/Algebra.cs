using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algebra : MonoBehaviour
{
    // Start is called before the first frame update
public List<Sprite> formula = new List<Sprite>();
public SpriteRenderer algebraFormula;

public void OperationsOnFunctions()
{
    algebraFormula.sprite = formula[0];
}
public void SpecialProducts()
{
    algebraFormula.sprite = formula[1];
}
public void ExponentialRules()
{
    algebraFormula.sprite = formula[2];
}

public void LogarithmicRules()
{
    algebraFormula.sprite = formula[3];
}
}
