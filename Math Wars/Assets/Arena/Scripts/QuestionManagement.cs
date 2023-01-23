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

// Arena Lists

        public List<Sprite> calquestions = new List<Sprite>();
        public List<Sprite> calanswers = new List<Sprite>();
     
        public List<Sprite> algequestions = new List<Sprite>();
        public List<Sprite> algeanswers = new List<Sprite>();

        public List<Sprite> trigoquestions = new List<Sprite>();
        public List<Sprite> trigoanswers = new List<Sprite>();

// Story Mode Lists

[Header("Level 1 Calculus")]
        public List<Sprite> Level1calquestions = new List<Sprite>();
        public List<Sprite> Level1calanswers = new List<Sprite>();
[Header("Level 2 Calculus")]
        public List<Sprite> Level2calquestions = new List<Sprite>();
        public List<Sprite> Level2calanswers = new List<Sprite>();
[Header("Level 3 Calculus")]
        public List<Sprite> Level3calquestions = new List<Sprite>();
        public List<Sprite> Level3calanswers = new List<Sprite>();
[Header("Level 4 Calculus")]
        public List<Sprite> Level4calquestions = new List<Sprite>();
        public List<Sprite> Level4calanswers = new List<Sprite>();
[Header("Level 5 Calculus")]
        public List<Sprite> Level5calquestions = new List<Sprite>();
        public List<Sprite> Level5calanswers = new List<Sprite>();

[Header("Level 1 Algebra")]
        public List<Sprite> Level1algequestions = new List<Sprite>();
        public List<Sprite> Level1algeanswers = new List<Sprite>();
[Header("Level 2 Algebra")]
        public List<Sprite> Level2algequestions = new List<Sprite>();
        public List<Sprite> Level2algeanswers = new List<Sprite>();
[Header("Level 3 Algebra")]
        public List<Sprite> Level3algequestions = new List<Sprite>();
        public List<Sprite> Level3algeanswers = new List<Sprite>();
[Header("Level 4 Algebra")]
        public List<Sprite> Level4algequestions = new List<Sprite>();
        public List<Sprite> Level4algeanswers = new List<Sprite>();
[Header("Level 5 Algebra")]
        public List<Sprite> Level5algequestions = new List<Sprite>();
        public List<Sprite> Level5algeanswers = new List<Sprite>();

[Header("Level 1 Trigonometry")]
        public List<Sprite> Level1trigoquestions = new List<Sprite>();
        public List<Sprite> Level1trigoanswers = new List<Sprite>();
[Header("Level 2 Trigonometry")]
        public List<Sprite> Level2trigoquestions = new List<Sprite>();
        public List<Sprite> Level2trigoanswers = new List<Sprite>();
[Header("Level 3 Trigonometry")]
        public List<Sprite> Level3trigoquestions = new List<Sprite>();
        public List<Sprite> Level3trigoanswers = new List<Sprite>();
[Header("Level 4 Trigonometry")]
        public List<Sprite> Level4trigoquestions = new List<Sprite>();
        public List<Sprite> Level4trigoanswers = new List<Sprite>();
[Header("Level 5 Trigonometry")]
        public List<Sprite> Level5trigoquestions = new List<Sprite>();
        public List<Sprite> Level5trigoanswers = new List<Sprite>();
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

//Story Mode Questions (answers to be replaced)

/*public void AlgebraLevel1()
{
dice = Random.Range(0,30);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level1algequestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = Level1algequestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = Level1algequestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = Level1algequestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = Level1algequestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = Level1algequestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = Level1algequestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = Level1algequestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = Level1algequestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = Level1algequestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = Level1algequestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = Level1algequestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = Level1algequestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = Level1algequestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = Level1algequestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = Level1algequestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = Level1algequestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = Level1algequestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = Level1algequestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = Level1algequestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = Level1algequestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = Level1algequestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = Level1algequestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = Level1algequestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = Level1algequestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = Level1algequestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = Level1algequestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = Level1algequestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = Level1algequestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = Level1algequestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1algeanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1algeanswers[119];
    answer = "A";
break;
}
}
*/
/*public void AlgebraLevel2()
{
dice = Random.Range(0,30);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level2algequestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = Level2algequestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = Level2algequestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = Level2algequestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = Level2algequestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = Level2algequestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = Level2algequestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = Level2algequestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = Level2algequestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = Level2algequestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = Level2algequestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = Level2algequestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = Level2algequestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = Level2algequestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = Level2algequestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = Level2algequestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = Level2algequestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = Level2algequestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = Level2algequestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = Level2algequestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = Level2algequestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = Level2algequestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = Level2algequestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = Level2algequestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = Level2algequestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = Level2algequestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = Level2algequestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = Level2algequestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = Level2algequestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = Level2algequestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2algeanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2algeanswers[119];
    answer = "A";
break;
}
}
*/
/*public void AlgebraLevel3()
{
dice = Random.Range(0,30);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level3algequestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = Level3algequestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = Level3algequestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = Level3algequestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = Level3algequestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = Level3algequestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = Level3algequestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = Level3algequestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = Level3algequestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = Level3algequestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = Level3algequestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = Level3algequestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = Level3algequestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = Level3algequestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = Level3algequestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = Level3algequestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = Level3algequestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = Level3algequestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = Level3algequestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = Level3algequestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = Level3algequestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = Level3algequestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = Level3algequestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = Level3algequestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = Level3algequestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = Level3algequestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = Level3algequestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = Level3algequestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Levela3lgeanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = Level3algequestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = Level3algequestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3algeanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3algeanswers[119];
    answer = "A";
break;
}
}
*/
/*public void AlgebraLevel4()
{
dice = Random.Range(0,30);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level4algequestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = Level4algequestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = Level4algequestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = Level4algequestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = Level4algequestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = Level4algequestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = Level4algequestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = Level4algequestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = Level4algequestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = Level4algequestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = Level4algequestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = Level4algequestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = Level4algequestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = Level4algequestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = Level4algequestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = Level4algequestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = Level4algequestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = Level4algequestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = Level4algequestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = Level4algequestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[79];
    answer = "A";
break;

case 20:
    question.GetComponent<Image>().sprite = Level4algequestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[83];
    answer = "C";
break;

case 21:
    question.GetComponent<Image>().sprite = Level4algequestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[87];
    answer = "A";
break;

case 22:
    question.GetComponent<Image>().sprite = Level4algequestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[91];
    answer = "C";
break;

case 23:
    question.GetComponent<Image>().sprite = Level4algequestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[95];
    answer = "B";
break;

case 24:
    question.GetComponent<Image>().sprite = Level4algequestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[99];
    answer = "D";
break;

case 25:
    question.GetComponent<Image>().sprite = Level4algequestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[103];
    answer = "A";
break;

case 26:
    question.GetComponent<Image>().sprite = Level4algequestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[107];
    answer = "C";
break;

case 27:
    question.GetComponent<Image>().sprite = Level4algequestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[111];
    answer = "D";
break;

case 28:
    question.GetComponent<Image>().sprite = Level4algequestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[115];
    answer = "A";
break;

case 29:
    question.GetComponent<Image>().sprite = Level4algequestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4algeanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4algeanswers[119];
    answer = "A";
break;
}
}
*/
/*public void AlgebraLevel5()
{
dice = Random.Range(0,30);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level5algequestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5algeanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5algeanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5algeanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5algeanswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = Level5algequestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5algeanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5algeanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5algeanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5algeanswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = Level5algequestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5algeanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5algeanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5algeanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5algeanswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = Level5algequestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level5algequestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level5algequestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level5algequestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level5algequestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level5algequestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level5algequestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level5algequestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level5algequestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level5algequestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level5algequestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level5algequestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level5algequestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level5algequestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level5algequestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level5algequestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level5algequestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level5algequestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level5algequestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level5algequestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level5algequestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level5algequestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level5algequestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level5algequestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level5algequestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level5algequestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level5algequestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Leve5algeanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Leve5algeanswers[119];
    answer = "A";
break;
}
}


*/
/*public void TrigonometryLevel1()

{
dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level1trigoquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level1trigoquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level1trigoquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level1trigoquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level1trigoquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level1trigoquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level1trigoquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level1trigoquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level1trigoquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level1trigoquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level1trigoquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level1trigoquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level1trigoquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level1trigoquestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level1trigoquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level1trigoquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level1trigoquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level1trigoquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level1trigoquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level1trigoquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level1trigoquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level1trigoquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level1trigoquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level1trigoquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level1trigoquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level1trigoquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level1trigoquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level1trigoquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level1trigoquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level1trigoquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1trigoanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1trigoanswers[119];
    answer = "A";
break;
}
}
*/
/*public void TrigonometryLevel2()

{
dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level2trigoquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level2trigoquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level2trigoquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level2trigoquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level2trigoquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level2trigoquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level2trigoquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level2trigoquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level2trigoquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level2trigoquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level2trigoquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level2trigoquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level2trigoquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level2trigoquestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level2trigoquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level2trigoquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level2trigoquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level2trigoquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level2trigoquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level2trigoquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level2trigoquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level2trigoquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level2trigoquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level2trigoquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level2trigoquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level2trigoquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level2trigoquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level2trigoquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level2trigoquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level2trigoquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2trigoanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2trigoanswers[119];
    answer = "A";
break;
}
}
*/
/*public void TrigonometryLevel3()
{
dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level3trigoquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level3trigoquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level3trigoquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level3trigoquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level3trigoquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level3trigoquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level3trigoquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level3trigoquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level3trigoquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level3trigoquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level3trigoquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level3trigoquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level3trigoquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level3trigoquestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level3trigoquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level3trigoquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level3trigoquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level3trigoquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level3trigoquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level3trigoquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level3trigoquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level3trigoquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level3trigoquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level3trigoquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level3trigoquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level3trigoquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level3trigoquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level3trigoquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level3trigoquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level3trigoquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3trigoanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3trigoanswers[119];
    answer = "A";
break;
}
}
*/
/*public void TrigonometryLevel4()
{
dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level4trigoquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level4trigoquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level4trigoquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level4trigoquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level4trigoquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level4trigoquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level4trigoquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level4trigoquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level4trigoquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level4trigoquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level4trigoquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level4trigoquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level4trigoquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level4trigoquestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level4trigoquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level4trigoquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level4trigoquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level4trigoquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level4trigoquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level4trigoquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level4trigoquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level4trigoquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level4trigoquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level4trigoquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level4trigoquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level4trigoquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level4trigoquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level4trigoquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level4trigoquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level4trigoquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4trigoanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4trigoanswers[119];
    answer = "A";
break;
}
}

*/
/*public void TrigonometryLevel5()
{
dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level5trigoquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level5trigoquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level5trigoquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level5trigoquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level5trigoquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level5trigoquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level5trigoquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level5trigoquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level5trigoquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level5trigoquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level5trigoquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level5trigoquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level5trigoquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level5trigoquestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level5trigoquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level5trigoquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level5trigoquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level5trigoquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level5trigoquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level5trigoquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level5trigoquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level5trigoquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level5trigoquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level5trigoquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level5trigoquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level5trigoquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level5trigoquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level5trigoquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level5trigoquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level5trigoquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5trigoanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5trigoanswers[119];
    answer = "A";
break;
}
}

*/
/*public void CalculusLevel1()
{


dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level1calquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level1calquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level1calquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level1calquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level1calquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level1calquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level1calquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level1calquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level1calquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level1calquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level1calquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level1calquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level1calquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level1calquestions[13];
 choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level1calquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level1calquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level1calquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level1calquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level1calquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level1calquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level1calquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level1calquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level1calquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level1calquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level1calquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level1calquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level1calquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level1calquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level1calquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level1calquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level1calanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level1calanswers[119];
    answer = "A";
break;
}
}

*/
/*public void CalculusLevel2()
{


dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level2calquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level2calquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level2calquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level2calquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level2calquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level2calquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level2calquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level2calquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level2calquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level2calquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level2calquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level2calquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level2calquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level2calquestions[13];
 choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level2calquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level2calquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level2calquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level2calquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level2calquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level2calquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level2calquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level2calquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level2calquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level2calquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level2calquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level2calquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level2calquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level2calquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level2calquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level2calquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level2calanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level2calanswers[119];
    answer = "A";
break;
}
}
*/
/*public void CalculusLevel3()
{


dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level3calquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level3calquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level3calquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level3calquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level3calquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level3calquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level3calquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level3calquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level3calquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level3calquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level3calquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level3calquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level3calquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level3calquestions[13];
 choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level3calquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level3calquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level3calquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level3calquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level3calquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level3calquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level3calquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level3calquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level3calquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level3calquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level3calquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level3calquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level3calquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level3calquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level3calquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level3calquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level3calanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level3calanswers[119];
    answer = "A";
break;
}
}
*/
/*public void CalculusLevel4()
{


dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level4calquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level4calquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level4calquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level4calquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level4calquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level4calquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level4calquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level4calquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level4calquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level4calquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level4calquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level4calquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level4calquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level4calquestions[13];
 choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level4calquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level4calquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level4calquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level4calquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level4calquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level4calquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level4calquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level4calquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level4calquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level4calquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level4calquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level4calquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level4calquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level4calquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level4calquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level4calquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level4calanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level4calanswers[119];
    answer = "A";
break;
}
}
*/
/*public void CalculusLevel5()
{


dice = Random.Range(0,30);


switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = Level5calquestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[3];
    answer = "A";
break;


case 1:
    question.GetComponent<Image>().sprite = Level5calquestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[7];
    answer = "D";
break;


case 2:
    question.GetComponent<Image>().sprite = Level5calquestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[11];
    answer = "A";
break;


case 3:
    question.GetComponent<Image>().sprite = Level5calquestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[15];
    answer = "B";
break;


case 4:
    question.GetComponent<Image>().sprite = Level5calquestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[19];
    answer = "C";
break;


case 5:
    question.GetComponent<Image>().sprite = Level5calquestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[23];
    answer = "D";
break;


case 6:
    question.GetComponent<Image>().sprite = Level5calquestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[27];
    answer = "A";
break;


case 7:
    question.GetComponent<Image>().sprite = Level5calquestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[31];
    answer = "A";
break;


case 8:
    question.GetComponent<Image>().sprite = Level5calquestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[35];
    answer = "A";
break;


case 9:
    question.GetComponent<Image>().sprite = Level5calquestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[39];
    answer = "A";
break;


case 10:
    question.GetComponent<Image>().sprite = Level5calquestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[43];
    answer = "D";
break;


case 11:
    question.GetComponent<Image>().sprite = Level5calquestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[47];
    answer = "A";
break;


case 12:
    question.GetComponent<Image>().sprite = Level5calquestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[51];
    answer = "D";
break;


case 13:
    question.GetComponent<Image>().sprite = Level5calquestions[13];
 choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[55];
    answer = "C";
break;


case 14:
    question.GetComponent<Image>().sprite = Level5calquestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[59];
    answer = "C";
break;


case 15:
    question.GetComponent<Image>().sprite = Level5calquestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[63];
    answer = "A";
break;


case 16:
    question.GetComponent<Image>().sprite = Level5calquestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[67];
    answer = "D";
break;


case 17:
    question.GetComponent<Image>().sprite = Level5calquestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[71];
    answer = "A";
break;


case 18:
    question.GetComponent<Image>().sprite = Level5calquestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[75];
    answer = "C";
break;


case 19:
    question.GetComponent<Image>().sprite = Level5calquestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[79];
    answer = "A";
break;


case 20:
    question.GetComponent<Image>().sprite = Level5calquestions[20];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[80];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[81];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[82];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[83];
    answer = "C";
break;


case 21:
    question.GetComponent<Image>().sprite = Level5calquestions[21];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[84];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[85];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[86];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[87];
    answer = "A";
break;


case 22:
    question.GetComponent<Image>().sprite = Level5calquestions[22];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[88];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[89];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[90];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[91];
    answer = "C";
break;


case 23:
    question.GetComponent<Image>().sprite = Level5calquestions[23];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[92];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[93];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[94];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[95];
    answer = "B";
break;


case 24:
    question.GetComponent<Image>().sprite = Level5calquestions[24];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[96];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[97];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[98];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[99];
    answer = "D";
break;


case 25:
    question.GetComponent<Image>().sprite = Level5calquestions[25];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[100];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[101];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[102];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[103];
    answer = "A";
break;


case 26:
    question.GetComponent<Image>().sprite = Level5calquestions[26];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[104];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[105];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[106];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[107];
    answer = "C";
break;


case 27:
    question.GetComponent<Image>().sprite = Level5calquestions[27];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[108];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[109];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[110];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[111];
    answer = "D";
break;


case 28:
    question.GetComponent<Image>().sprite = Level5calquestions[28];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[112];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[113];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[114];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[115];
    answer = "A";
break;


case 29:
    question.GetComponent<Image>().sprite = Level5calquestions[29];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = Level5calanswers[116];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[117];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[118];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = Level5calanswers[119];
    answer = "A";
break;
}
}
*/


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

