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
    question.GetComponent<Image>().sprite = algequestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = algequestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = algequestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = algequestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = algequestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = algequestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = algequestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = algequestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = algequestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = algequestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = algequestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = algequestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = algequestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = algequestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = algequestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[59];
    answer = "C";
break;
}
}





public void Arithmetic()
{
dice = Random.Range(0,14);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = artquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[3];
    answer = "D";
break;

case 1:
    question.GetComponent<Image>().sprite = artquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = artquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = artquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[15];
    answer = "A";
break;

case 4:
    question.GetComponent<Image>().sprite = artquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[19];
    answer = "D";
break;

case 5:
    question.GetComponent<Image>().sprite = artquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[23];
    answer = "A";
break;

case 6:
    question.GetComponent<Image>().sprite = artquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[27];
    answer = "C";
break;

case 7:
    question.GetComponent<Image>().sprite = artquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[31];
    answer = "D";
break;

case 8:
    question.GetComponent<Image>().sprite = artquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[35];
    answer = "B";
break;

case 9:
    question.GetComponent<Image>().sprite = artquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[39];
    answer = "B";
break;

case 10:
    question.GetComponent<Image>().sprite = artquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[43];
    answer = "A";
break;

case 11:
    question.GetComponent<Image>().sprite = artquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[47];
    answer = "C";
break;

case 12:
    question.GetComponent<Image>().sprite = artquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[51];
    answer = "A";
break;

case 13:
    question.GetComponent<Image>().sprite = artquestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[55];
    answer = "A";
break;

case 14:
    question.GetComponent<Image>().sprite = artquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = artanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = artanswers[59];
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

