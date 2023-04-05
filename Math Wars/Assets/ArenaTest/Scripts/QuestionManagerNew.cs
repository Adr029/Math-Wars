using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionManagerNew : MonoBehaviour
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

// Arena Lists

        public List<Sprite> calquestions = new List<Sprite>();
        public List<Sprite> calanswers = new List<Sprite>();
     
        public List<Sprite> algequestions = new List<Sprite>();
        public List<Sprite> algeanswers = new List<Sprite>();

        public List<Sprite> trigoquestions = new List<Sprite>();
        public List<Sprite> trigoanswers = new List<Sprite>();

public void Calculus()
{

dice = Random.Range(0,30);

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

case 7:
    question.GetComponent<Image>().sprite = calquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = calquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = calquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = calquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = calquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = calquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = calquestions[13];
 choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = calquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = calquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = calquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = calquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = calquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = calquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = calquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = calquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = calquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = calquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = calquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = calquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = calquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = calquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = calquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = calquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = calanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = calanswers[119];
    answer = "A";
break;
}
}

public void Algebra()
{
dice = Random.Range(0,30);

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

case 15:
    question.GetComponent<Image>().sprite = algequestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = algequestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = algequestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = algequestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = algequestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = algequestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = algequestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = algequestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = algequestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = algequestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = algequestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = algequestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = algequestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = algequestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = algequestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = algeanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = algeanswers[119];
    answer = "A";
break;
}
}

public void Trigonometry()
{
dice = Random.Range(0,30);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = trigoquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = trigoquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = trigoquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = trigoquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = trigoquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = trigoquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = trigoquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = trigoquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = trigoquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = trigoquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = trigoquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = trigoquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = trigoquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = trigoquestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = trigoquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = trigoquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = trigoquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = trigoquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = trigoquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = trigoquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = trigoquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = trigoquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = trigoquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = trigoquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = trigoquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = trigoquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = trigoquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = trigoquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = trigoquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = trigoquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = trigoanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = trigoanswers[119];
    answer = "A";
break;
}
}


// answer confirmation
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

