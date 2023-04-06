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

dice = Random.Range(0,10);

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
}
}
public void BeginnerTrigo()
{

dice = Random.Range(0,10);

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
}
}
public void BeginnerCal()
{

dice = Random.Range(0,10);

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
}
}


public void IntermediateAlge()
{
dice = Random.Range(0,10);

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
}
}
public void IntermediateTrigo()
{
dice = Random.Range(0,10);

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
}
}
public void IntermediateCal()
{
dice = Random.Range(0,10);

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
}
}


public void AdvanceAlge()
{
dice = Random.Range(0,10);

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
}
}
public void AdvanceTrigo()
{
dice = Random.Range(0,0);

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
}
}
public void AdvanceCal()
{
dice = Random.Range(0,30);

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

