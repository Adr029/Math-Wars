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
    question.GetComponent<Image>().sprite = calquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = calquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = calquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = calquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = calquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = calquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = calquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[27];
    answer = "A";
break;

/*case 7:
    question.GetComponent<Image>().sprite = calquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[31];
    answer = "";
break;

case 8:
    question.GetComponent<Image>().sprite = calquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[35];
    answer = "";
break;

case 9:
    question.GetComponent<Image>().sprite = calquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[39];
    answer = "";
break;

case 10:
    question.GetComponent<Image>().sprite = calquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[43];
    answer = "";
break;

case 11:
    question.GetComponent<Image>().sprite = calquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[47];
    answer = "";
break;

case 12:
    question.GetComponent<Image>().sprite = calquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[51];
    answer = "";
break;

case 13:
    question.GetComponent<Image>().sprite = calquestions[13];
 choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[55];
    answer = "";
break;

case 14:
    question.GetComponent<Image>().sprite = calquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[59];
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

