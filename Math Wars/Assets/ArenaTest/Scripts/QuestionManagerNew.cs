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

        public List<Sprite> BeginnerQuestions = new List<Sprite>();
        public List<Sprite> BeginnerAnswers = new List<Sprite>();
     
        public List<Sprite> IntermediateQuestions = new List<Sprite>();
        public List<Sprite> IntermediateAnswers = new List<Sprite>();

        public List<Sprite> AdvanceQuestions = new List<Sprite>();
        public List<Sprite> AdvanceAnswers = new List<Sprite>();

public void Beginner()
{

dice = Random.Range(0,30);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = BeginnerQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = BeginnerQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = BeginnerQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = BeginnerQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = BeginnerQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = BeginnerQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = BeginnerQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = BeginnerQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = BeginnerQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = BeginnerQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = BeginnerQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = BeginnerQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = BeginnerQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = BeginnerQuestions[13];
 choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = BeginnerQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = BeginnerQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = BeginnerQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = BeginnerQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = BeginnerQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = BeginnerQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = BeginnerQuestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = BeginnerQuestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = BeginnerQuestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = BeginnerQuestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = BeginnerQuestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = BeginnerQuestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = BeginnerQuestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = BeginnerQuestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = BeginnerQuestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = BeginnerQuestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BeginnerAnswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BeginnerAnswers[119];
    answer = "A";
break;
}
}

public void Intermediate()
{
dice = Random.Range(0,30);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = IntermediateQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = IntermediateQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = IntermediateQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = IntermediateQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = IntermediateQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = IntermediateQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = IntermediateQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = IntermediateQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = IntermediateQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = IntermediateQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = IntermediateQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = IntermediateQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = IntermediateQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = IntermediateQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = IntermediateQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = IntermediateQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = IntermediateQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = IntermediateQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = IntermediateQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = IntermediateQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = IntermediateQuestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = IntermediateQuestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = IntermediateQuestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = IntermediateQuestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = IntermediateQuestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = IntermediateQuestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = IntermediateQuestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = IntermediateQuestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = IntermediateQuestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = IntermediateQuestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = IntermediateAnswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = IntermediateAnswers[119];
    answer = "A";
break;
}
}

public void Advance()
{
dice = Random.Range(0,30);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = AdvanceQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = AdvanceQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = AdvanceQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = AdvanceQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = AdvanceQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = AdvanceQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = AdvanceQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = AdvanceQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = AdvanceQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = AdvanceQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = AdvanceQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = AdvanceQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = AdvanceQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = AdvanceQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = AdvanceQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = AdvanceQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = AdvanceQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = AdvanceQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = AdvanceQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = AdvanceQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = AdvanceQuestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = AdvanceQuestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = AdvanceQuestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = AdvanceQuestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = AdvanceQuestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = AdvanceQuestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = AdvanceQuestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = AdvanceQuestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = AdvanceQuestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = AdvanceQuestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanceAnswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanceAnswers[119];
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

