using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionManagement : MonoBehaviour
{
    public Button choiceA;
    public Button choiceB;
    public Button choiceC;
    public Button choiceD;
    public int dice;
    public string answer;
    public bool correct;
    public Text correctText;
    public Image question;
    [Header("Calculus Questions")]

    public Sprite calq1;
    public Sprite calq2;
    public Sprite calq3;
    public Sprite calq4;
    public Sprite calq5;
    public Sprite calq6;
    public Sprite calq7;

    [Header("Calculus Answers")]
    public Sprite cal1;
    public Sprite cal2;
    public Sprite cal3;
    public Sprite cal4;

    public Sprite cal5;
    public Sprite cal6;
    public Sprite cal7;
    public Sprite cal8;
    
    public Sprite cal9;
    public Sprite cal10;
    public Sprite cal11;
    public Sprite cal12;

    public Sprite cal13;
    public Sprite cal14;
    public Sprite cal15;
    public Sprite cal16;

    public Sprite cal17;
    public Sprite cal18;
    public Sprite cal19;
    public Sprite cal20;

    public Sprite cal21;
    public Sprite cal22;
    public Sprite cal23;
    public Sprite cal24;

    public Sprite cal25;
    public Sprite cal26;
    public Sprite cal27;
    public Sprite cal28;

public void Arithmetic()
{



}


public void Algebra()
{


}
public void Calculus()
{

dice = Random.Range(0,7);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = calq1;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal1;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = cal2;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = cal3;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = cal4;
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = calq2;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal5;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = cal6;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = cal7;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = cal8;
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = calq3;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal9;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = cal10;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = cal11;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = cal12;
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = calq4;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal13;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = cal14;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = cal15;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = cal16;
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = calq5;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal17;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = cal18;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = cal19;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = cal20;
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = calq6;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal21;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = cal22;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = cal23;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = cal24;
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = calq7;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal25;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = cal26;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = cal27;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = cal28;
    answer = "A";
break;
}

}
public void AnswerA()
{
    if (answer == "A")
    {
        correct = true;
    }
    else
    {
        correct = false;
    }
}
public void AnswerB()
{
    if (answer == "B")
    {
        correct = true;
    }
    else
    {
        correct = false;
    }
}
public void AnswerC()
{
    if (answer == "C")
    {
        correct = true;
    }
    else
    {
        correct = false;
    }
}
public void AnswerD()
{
    if (answer == "D")
    {
        correct = true;
    }
    else
    {
        correct = false;
    }
}
}

