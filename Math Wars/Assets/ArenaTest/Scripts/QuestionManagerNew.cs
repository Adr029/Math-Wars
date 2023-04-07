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

[Header("Beginner")]
        public List<Sprite> BegAlgeQuestions = new List<Sprite>();
        public List<Sprite> BegAlgeAnswers = new List<Sprite>();
        public List<Sprite> BegTrigoQuestions = new List<Sprite>();
        public List<Sprite> BegTrigoAnswers = new List<Sprite>();
        public List<Sprite> BegCalQuestions = new List<Sprite>();
        public List<Sprite> BegCalAnswers = new List<Sprite>();

[Header("Intermediate")]
        public List<Sprite> InterAlgeQuestions = new List<Sprite>();
        public List<Sprite> InterAlgeAnswers = new List<Sprite>();
        public List<Sprite> InterTrigoQuestions = new List<Sprite>();
        public List<Sprite> InterTrigoAnswers = new List<Sprite>();
        public List<Sprite> InterCalQuestions = new List<Sprite>();
        public List<Sprite> InterCalAnswers = new List<Sprite>();

[Header("Advance")]
        public List<Sprite> AdvanAlgeQuestions = new List<Sprite>();
        public List<Sprite> AdvanAlgeAnswers = new List<Sprite>();
        public List<Sprite> AdvanTrigoQuestions = new List<Sprite>();
        public List<Sprite> AdvanTrigoAnswers = new List<Sprite>();
        public List<Sprite> AdvanCalQuestions = new List<Sprite>();
        public List<Sprite> AdvanCalAnswers = new List<Sprite>();

public void BeginnerAlge()
{

dice = Random.Range(0,20);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegAlgeAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegAlgeAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegAlgeAnswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegAlgeAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegAlgeAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegAlgeAnswers[43];
    answer = "A";
break;

case 11:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[47];
    answer = "D";
break;

case 12:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[51];
    answer = "A";
break;

case 13:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[55];
    answer = "B";
break;

case 14:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[63];
    answer = "D";
break;

case 16:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[67];
    answer = "A";
break;

case 17:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[75];
    answer = "A";
break;

case 19:
    question.GetComponent<Image>().sprite = BegAlgeQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegAlgeAnswers[79];
    answer = "A";
break;

}
}
public void BeginnerTrigo()
{

dice = Random.Range(0,20);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[3];
    answer = "D";
break;

case 1:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[7];
    answer = "A";
break;

case 2:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[11];
    answer = "D";
break;

case 3:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[15];
    answer = "C";
break;

case 4:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[23];
    answer = "A";
break;

case 6:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[27];
    answer = "D";
break;

case 7:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[35];
    answer = "C";
break;

case 9:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = BegTrigoQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegTrigoAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegTrigoAnswers[79];
    answer = "A";
break;

}
}
public void BeginnerCal()
{

dice = Random.Range(0,20);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = BegCalQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[3];
    answer = "C";
break;

case 1:
    question.GetComponent<Image>().sprite = BegCalQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[7];
    answer = "A";
break;

case 2:
    question.GetComponent<Image>().sprite = BegCalQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegCalAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[11];
    answer = "C";
break;

case 3:
    question.GetComponent<Image>().sprite = BegCalQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegCalAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = BegCalQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[19];
    answer = "D";
break;

case 5:
    question.GetComponent<Image>().sprite = BegCalQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[23];
    answer = "A";
break;

case 6:
    question.GetComponent<Image>().sprite = BegCalQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[27];
    answer = "C";
break;

case 7:
    question.GetComponent<Image>().sprite = BegCalQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[31];
    answer = "D";
break;

case 8:
    question.GetComponent<Image>().sprite = BegCalQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = BegCalQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = BegCalQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[43];
    answer = "C";
break;

case 11:
    question.GetComponent<Image>().sprite = BegCalQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = BegCalQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegCalAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[51];
    answer = "C";
break;

case 13:
    question.GetComponent<Image>().sprite = BegCalQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = BegCalAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[55];
    answer = "B";
break;

case 14:
    question.GetComponent<Image>().sprite = BegCalQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[59];
    answer = "D";
break;

case 115:
    question.GetComponent<Image>().sprite = BegCalQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = BegCalQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[67];
    answer = "C";
break;

case 17:
    question.GetComponent<Image>().sprite = BegCalQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[71];
    answer = "D";
break;

case 18:
    question.GetComponent<Image>().sprite = BegCalQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[75];
    answer = "A";
break;

case 19:
    question.GetComponent<Image>().sprite = BegCalQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = BegCalAnswers[79];
    answer = "A";
break;

}
}


public void IntermediateAlge()
{
dice = Random.Range(0,20);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[43];
    answer = "A";
break;

case 11:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[47];
    answer = "D";
break;

case 12:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[51];
    answer = "A";
break;

case 13:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[55];
    answer = "B";
break;

case 14:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[63];
    answer = "D";
break;

case 16:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[67];
    answer = "A";
break;

case 17:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[75];
    answer = "A";
break;

case 19:
    question.GetComponent<Image>().sprite = InterAlgeQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterAlgeAnswers[79];
    answer = "A";
break;

}
}
public void IntermediateTrigo()
{
dice = Random.Range(0,20);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[3];
    answer = "D";
break;

case 1:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[7];
    answer = "A";
break;

case 2:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[11];
    answer = "D";
break;

case 3:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[15];
    answer = "C";
break;

case 4:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[23];
    answer = "A";
break;

case 6:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[27];
    answer = "D";
break;

case 7:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[35];
    answer = "C";
break;

case 9:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = InterTrigoQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterTrigoAnswers[79];
    answer = "A";
break;

}
}
public void IntermediateCal()
{
dice = Random.Range(0,20);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = InterCalQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[3];
    answer = "C";
break;

case 1:
    question.GetComponent<Image>().sprite = InterCalQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[7];
    answer = "A";
break;

case 2:
    question.GetComponent<Image>().sprite = InterCalQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[11];
    answer = "C";
break;

case 3:
    question.GetComponent<Image>().sprite = InterCalQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = InterCalQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[19];
    answer = "D";
break;

case 5:
    question.GetComponent<Image>().sprite = InterCalQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[23];
    answer = "A";
break;

case 6:
    question.GetComponent<Image>().sprite = InterCalQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[27];
    answer = "C";
break;

case 7:
    question.GetComponent<Image>().sprite = InterCalQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[31];
    answer = "D";
break;

case 8:
    question.GetComponent<Image>().sprite = InterCalQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = InterCalQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = InterCalQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[43];
    answer = "C";
break;

case 11:
    question.GetComponent<Image>().sprite = InterCalQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = InterCalQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[51];
    answer = "C";
break;

case 13:
    question.GetComponent<Image>().sprite = InterCalQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[55];
    answer = "B";
break;

case 14:
    question.GetComponent<Image>().sprite = InterCalQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[59];
    answer = "D";
break;

case 15:
    question.GetComponent<Image>().sprite = InterCalQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = InterCalQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[67];
    answer = "C";
break;

case 17:
    question.GetComponent<Image>().sprite = InterCalQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[71];
    answer = "D";
break;

case 18:
    question.GetComponent<Image>().sprite = InterCalQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[75];
    answer = "A";
break;

case 19:
    question.GetComponent<Image>().sprite = InterCalQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = InterCalAnswers[79];
    answer = "A";
break;

}
}


public void AdvanceAlge()
{
dice = Random.Range(0,20);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[3];
    answer = "A";
break;

case 1:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[7];
    answer = "D";
break;

case 2:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[11];
    answer = "A";
break;

case 3:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[23];
    answer = "D";
break;

case 6:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[27];
    answer = "A";
break;

case 7:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[43];
    answer = "A";
break;

case 11:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[47];
    answer = "D";
break;

case 12:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[51];
    answer = "A";
break;

case 13:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[55];
    answer = "B";
break;

case 14:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[63];
    answer = "D";
break;

case 16:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[67];
    answer = "A";
break;

case 17:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[75];
    answer = "A";
break;

case 19:
    question.GetComponent<Image>().sprite = AdvanAlgeQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanAlgeAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanAlgeAnswers[79];
    answer = "A";
break;

}
}
public void AdvanceTrigo()
{
dice = Random.Range(0,20);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[3];
    answer = "D";
break;

case 1:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[7];
    answer = "A";
break;

case 2:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[11];
    answer = "D";
break;

case 3:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[15];
    answer = "C";
break;

case 4:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[19];
    answer = "C";
break;

case 5:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[23];
    answer = "A";
break;

case 6:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[27];
    answer = "D";
break;

case 7:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[31];
    answer = "A";
break;

case 8:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[35];
    answer = "C";
break;

case 9:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[43];
    answer = "D";
break;

case 11:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[51];
    answer = "D";
break;

case 13:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[55];
    answer = "C";
break;

case 14:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[59];
    answer = "C";
break;

case 15:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[67];
    answer = "D";
break;

case 17:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[71];
    answer = "A";
break;

case 18:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[75];
    answer = "C";
break;

case 19:
    question.GetComponent<Image>().sprite = AdvanTrigoQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite = AdvanTrigoAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanTrigoAnswers[79];
    answer = "A";
break;

}
}
public void AdvanceCal()
{
dice = Random.Range(0,20);

switch (dice)
{
case 0:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[0];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[0];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[1];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[2];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[3];
    answer = "C";
break;

case 1:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[1];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[4];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[5];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[6];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[7];
    answer = "A";
break;

case 2:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[2];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[8];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[9];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[10];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[11];
    answer = "C";
break;

case 3:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[3];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[12];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[13];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[14];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[15];
    answer = "B";
break;

case 4:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[4];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[16];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[17];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[18];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[19];
    answer = "D";
break;

case 5:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[5];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[20];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[21];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[22];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[23];
    answer = "A";
break;

case 6:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[6];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[24];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[25];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[26];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[27];
    answer = "C";
break;

case 7:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[7];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[28];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[29];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[30];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[31];
    answer = "D";
break;

case 8:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[8];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[32];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[33];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[34];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[35];
    answer = "A";
break;

case 9:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[9];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[36];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[37];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[38];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[39];
    answer = "A";
break;

case 10:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[10];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[40];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[41];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[42];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[43];
    answer = "C";
break;

case 11:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[11];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[44];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[45];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[46];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[47];
    answer = "A";
break;

case 12:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[12];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[48];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[49];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[50];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[51];
    answer = "C";
break;

case 13:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[13];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[52];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[53];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[54];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[55];
    answer = "B";
break;

case 14:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[14];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[56];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[57];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[58];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[59];
    answer = "D";
break;

case 15:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[15];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[60];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[61];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[62];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[63];
    answer = "A";
break;

case 16:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[16];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[64];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[65];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[66];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[67];
    answer = "C";
break;

case 17:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[17];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[68];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[69];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[70];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[71];
    answer = "D";
break;

case 18:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[18];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[72];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[73];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[74];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[75];
    answer = "A";
break;

case 19:
    question.GetComponent<Image>().sprite = AdvanCalQuestions[19];
    choiceA.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[76];
    choiceB.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[77];
    choiceC.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[78];
    choiceD.transform.GetChild(1).GetComponent<Image>().sprite  = AdvanCalAnswers[79];
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

