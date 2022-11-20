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
    public Text question;
    public int dice;
    public string answer;
    public bool correct;


//future naming convention
//algebra1 2 3 4
//arithmetic 1 2 3 4
//calculus 1 2 3 4
    public Sprite ans1;
    public Sprite ans2;
    public Sprite ans3;
    public Sprite ans4;
public void Arithmetic()
{

dice = Random.Range(0,4);

switch (dice)
{
case 0:
question.text = "1+1?";

    choiceA.GetComponentInChildren<Text>().text = "1";
    choiceB.GetComponentInChildren<Text>().text = "2";
    choiceC.GetComponentInChildren<Text>().text = "infinity";
    choiceD.GetComponentInChildren<Text>().text = "5";
  
    /*
    choiceA.GetComponent<Image>().sprite = ans1;
    choiceB.GetComponent<Image>().sprite = ans2;
    choiceC.GetComponent<Image>().sprite = ans3;
    choiceD.GetComponent<Image>().sprite = ans4;
    */
    answer = "B";
break;

case 1:
question.text = "2+1?";
    choiceA.GetComponentInChildren<Text>().text = "2";
    choiceB.GetComponentInChildren<Text>().text = "3";
    choiceC.GetComponentInChildren<Text>().text = "infinity";
    choiceD.GetComponentInChildren<Text>().text = "8888";
    
    /*
    choiceA.GetComponent<Image>().sprite = ans2;
    choiceB.GetComponent<Image>().sprite = ans4;
    choiceC.GetComponent<Image>().sprite = ans1;
    choiceD.GetComponent<Image>().sprite = ans3;
    */
    answer = "B";
break;

case 2:
question.text = "3+1?";
    choiceA.GetComponentInChildren<Text>().text = "4";
    choiceB.GetComponentInChildren<Text>().text = "99";
    choiceC.GetComponentInChildren<Text>().text = "51521";
    choiceD.GetComponentInChildren<Text>().text = "8213";
   
    /*
    choiceA.GetComponent<Image>().sprite = ans1;
    choiceB.GetComponent<Image>().sprite = ans3;
    choiceC.GetComponent<Image>().sprite = ans2;
    choiceD.GetComponent<Image>().sprite = ans4;
    */
    answer = "A";
    
break;

case 3:
question.text = "5x5?";
    choiceA.GetComponentInChildren<Text>().text = "1";
    choiceB.GetComponentInChildren<Text>().text = "55";
    choiceC.GetComponentInChildren<Text>().text = "25";
    choiceD.GetComponentInChildren<Text>().text = "10";
    
    /*
    choiceA.GetComponent<Image>().sprite = ans3;
    choiceB.GetComponent<Image>().sprite = ans4;
    choiceC.GetComponent<Image>().sprite = ans2;
    choiceD.GetComponent<Image>().sprite = ans1;
    */
    answer = "C";
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

