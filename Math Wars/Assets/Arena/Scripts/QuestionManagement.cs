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

    //try gumawa ng list

        public List<Sprite> calquestions = new List<Sprite>();
        public List<Sprite> calanswers = new List<Sprite>();
        public List<Sprite> algequestions = new List<Sprite>();
        public List<Sprite> algeanswers = new List<Sprite>();
        public List<Sprite> artquestions = new List<Sprite>();
        public List<Sprite> artanswers = new List<Sprite>();


    [Header("Calculus Questions")]
    public Sprite calq1;    public Sprite calq2;    public Sprite calq3;    public Sprite calq4;    public Sprite calq5;
    public Sprite calq6;    public Sprite calq7;    public Sprite calq8;    public Sprite calq9;    public Sprite calq10;    
    public Sprite calq11;    public Sprite calq12;    public Sprite calq13;    public Sprite calq14;    public Sprite calq15;

    [Header("Calculus Answers")]
    public Sprite cal1;    public Sprite cal2;    public Sprite cal3;    public Sprite cal4;
    public Sprite cal5;    public Sprite cal6;    public Sprite cal7;    public Sprite cal8;    
    public Sprite cal9;    public Sprite cal10;    public Sprite cal11;    public Sprite cal12;
    public Sprite cal13;    public Sprite cal14;    public Sprite cal15;    public Sprite cal16;
    public Sprite cal17;    public Sprite cal18;    public Sprite cal19;    public Sprite cal20;
    public Sprite cal21;    public Sprite cal22;    public Sprite cal23;    public Sprite cal24;
    public Sprite cal25;    public Sprite cal26;    public Sprite cal27;    public Sprite cal28;
    public Sprite cal29;    public Sprite cal30;    public Sprite cal31;    public Sprite cal32;
    public Sprite cal33;    public Sprite cal34;    public Sprite cal35;    public Sprite cal36;
    public Sprite cal37;    public Sprite cal38;    public Sprite cal39;    public Sprite cal40;
    public Sprite cal41;    public Sprite cal42;    public Sprite cal43;    public Sprite cal44;
    public Sprite cal45;    public Sprite cal46;    public Sprite cal47;    public Sprite cal48;
    public Sprite cal49;    public Sprite cal50;    public Sprite cal51;    public Sprite cal52;
    public Sprite cal53;    public Sprite cal54;    public Sprite cal55;    public Sprite cal56;
    public Sprite cal57;    public Sprite cal58;    public Sprite cal59;    public Sprite cal60;


    [Header("Algebra Questions")]
    public Sprite alq1;    public Sprite alq2;    public Sprite alq3;    public Sprite alq4;    public Sprite alq5;
    public Sprite alq6;    public Sprite alq7;    public Sprite alq8;    public Sprite alq9;    public Sprite alq10;
    public Sprite alq11;    public Sprite alq12;    public Sprite alq13;    public Sprite alq14;    public Sprite alq15;    

    [Header("Algebra Answers")]
    public Sprite al1;    public Sprite al2;    public Sprite al3;    public Sprite al4;
    public Sprite al5;    public Sprite al6;    public Sprite al7;    public Sprite al8;    
    public Sprite al9;    public Sprite al10;    public Sprite al11;    public Sprite al12;
    public Sprite al13;    public Sprite al14;    public Sprite al15;    public Sprite al16;
    public Sprite al17;    public Sprite al18;    public Sprite al19;    public Sprite al20;
    public Sprite al21;    public Sprite al22;    public Sprite al23;    public Sprite al24;
    public Sprite al25;    public Sprite al26;    public Sprite al27;    public Sprite al28;
    public Sprite al29;    public Sprite al30;    public Sprite al31;    public Sprite al32;
    public Sprite al33;    public Sprite al34;    public Sprite al35;    public Sprite al36;
    public Sprite al37;    public Sprite al38;    public Sprite al39;    public Sprite al40;
    public Sprite al41;    public Sprite al42;    public Sprite al43;    public Sprite al44;
    public Sprite al45;    public Sprite al46;    public Sprite al47;   public Sprite al48;
    public Sprite al49;    public Sprite al50;    public Sprite al51;    public Sprite al52;
    public Sprite al53;    public Sprite al54;    public Sprite al55;    public Sprite al56;
    public Sprite al57;    public Sprite al58;    public Sprite al59;    public Sprite al60;


    [Header("Arithmetic Questions")]
    public Sprite artq1;    public Sprite artq2;    public Sprite artq3;    public Sprite artq4;    public Sprite artq5;
    public Sprite artq6;    public Sprite artq7;    public Sprite artq8;    public Sprite artq9;    public Sprite artq10;
    public Sprite artq11;    public Sprite artq12;    public Sprite artq13;    public Sprite artq14;    public Sprite artq15;    

    [Header("Algebra Answers")]
    public Sprite art1;    public Sprite art2;    public Sprite art3;    public Sprite art4;
    public Sprite art5;    public Sprite art6;    public Sprite art7;    public Sprite art8;    
    public Sprite art9;    public Sprite art10;    public Sprite art11;    public Sprite art12;
    public Sprite art13;    public Sprite art14;    public Sprite art15;    public Sprite art16;
    public Sprite art17;    public Sprite art18;    public Sprite art19;    public Sprite art20;
    public Sprite art21;    public Sprite art22;    public Sprite art23;    public Sprite art24;
    public Sprite art25;    public Sprite art26;    public Sprite art27;    public Sprite art28;
    public Sprite art29;    public Sprite art30;    public Sprite art31;    public Sprite art32;
    public Sprite art33;    public Sprite art34;    public Sprite art35;    public Sprite art36;
    public Sprite art37;    public Sprite art38;    public Sprite art39;    public Sprite art40;
    public Sprite art41;    public Sprite art42;    public Sprite art43;    public Sprite art44;
    public Sprite art45;    public Sprite art46;    public Sprite art47;   public Sprite art48;
    public Sprite art49;    public Sprite art50;    public Sprite art51;    public Sprite art52;
    public Sprite art53;    public Sprite art54;    public Sprite art55;    public Sprite art56;
    public Sprite art57;    public Sprite art58;    public Sprite art59;    public Sprite art60;



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

/*case 7:
    question.GetComponent<Image>().sprite = calq8;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal29;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = cal30;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = cal31;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = cal32;
    answer = "";
break;

case 8:
    question.GetComponent<Image>().sprite = calq9;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal33;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = cal34;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = cal35;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = cal36;
    answer = "";
break;

case 9:
    question.GetComponent<Image>().sprite = calq10;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal37;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = cal38;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = cal39;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = cal40;
    answer = "";
break;

case 10:
    question.GetComponent<Image>().sprite = calq11;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal41;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = cal42;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = cal43;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = cal44;
    answer = "";
break;

case 11:
    question.GetComponent<Image>().sprite = calq12;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal45;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = cal46;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = cal47;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = cal48;
    answer = "";
break;

case 12:
    question.GetComponent<Image>().sprite = calq13;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal49;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = cal50;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = cal51;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = cal52;
    answer = "";
break;

case 13:
    question.GetComponent<Image>().sprite = calq14;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal53;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = cal54;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = cal55;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = cal60;
    answer = "";
break;

case 14:
    question.GetComponent<Image>().sprite = calq15;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = cal53;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = cal54;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = cal55;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = cal60;
    answer = "";
break;*/
}
}




public void Algebra()
{
dice = Random.Range(0,14);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = alq1;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al1;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al2;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al3;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al4;
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = alq2;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al5;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al6;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al7;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al8;
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = alq3;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al9;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al10;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al11;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al12;
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = alq4;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al13;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al14;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al15;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al16;
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = alq5;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al17;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al18;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al19;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al20;
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = alq6;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al21;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al22;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al23;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al24;
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = alq7;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al25;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al26;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al27;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al28;
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = alq8;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al29;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al30;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al31;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al32;
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = alq9;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al33;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al34;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al35;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al36;
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = alq10;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al37;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al38;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al39;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al40;
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = alq11;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al41;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al42;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al43;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al44;
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = alq12;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al45;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al46;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al47;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al48;
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = alq13;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al49;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al50;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al51;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al52;
    answer = "D";
break;

/*case 13:
    question.GetComponent<Image>().sprite = alq14;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al53;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al54;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al55;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al60;
    answer = "";
break;

case 14:
    question.GetComponent<Image>().sprite = alq15;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al53;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al54;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al55;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al60;
    answer = "";
break;*/
}
}





public void Arithmetic()
{
dice = Random.Range(0,14);

/*switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = artq1;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art1;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art2;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art3;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art4;
    answer = "";
break;

case 1:
    question.GetComponent<Image>().sprite = artq2;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art5;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art6;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art7;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art8;
    answer = "";
break;

case 2:
    question.GetComponent<Image>().sprite = artq3;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art9;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art10;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art11;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art12;
    answer = "";
break;

case 3:
    question.GetComponent<Image>().sprite = artq4;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art13;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art14;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art15;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art16;
    answer = "";
break;

case 4:
    question.GetComponent<Image>().sprite = artq5;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art17;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art18;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art19;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art20;
    answer = "";
break;

case 5:
    question.GetComponent<Image>().sprite = artq6;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art21;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art22;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art23;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art24;
    answer = "";
break;

case 6:
    question.GetComponent<Image>().sprite = artq7;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art25;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art26;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art27;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art28;
    answer = "";
break;

case 7:
    question.GetComponent<Image>().sprite = artq8;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art29;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art30;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art31;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art32;
    answer = "";
break;

case 8:
    question.GetComponent<Image>().sprite = artq9;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art33;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art34;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art35;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art36;
    answer = "";
break;

case 9:
    question.GetComponent<Image>().sprite = artq10;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art37;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art38;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art39;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art40;
    answer = "";
break;

case 10:
    question.GetComponent<Image>().sprite = artq11;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art41;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art42;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art43;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art44;
    answer = "";
break;

case 11:
    question.GetComponent<Image>().sprite = artq12;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art45;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art46;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art47;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art48;
    answer = "";
break;

case 12:
    question.GetComponent<Image>().sprite = artq13;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art49;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art50;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art51;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art52;
    answer = "";
break;

case 13:
    question.GetComponent<Image>().sprite = artq14;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = art53;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = art54;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = art55;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = art56;
    answer = "";
break;

case 14:
    question.GetComponent<Image>().sprite = alq15;
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = al57;
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = al58;
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = al59;
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = al60;
    answer = "";
break;*/
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

