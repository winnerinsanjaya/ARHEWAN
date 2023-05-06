using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QUIZSCRIPT : MonoBehaviour
{

    public QNA QnA;


    public Text soal;
    public Text A, B, C, D;
    public int jawaban;

    public int Number;
    public int currentQuestion;

    public GameObject QuizPanel;
    public GameObject SelesaiPanel;

    public Text BenarText;

    public int benar;

    public GameObject HasilScreen;
    public Text Hasil;
    // Start is called before the first frame update
    void Start()
    {
        Number = 1;
        FirstToDo();
    }


    public void Pilihan(int number)
    {

        if(number == QnA.QuestionAndAnswer[currentQuestion].CorrectAnswer)
        {
            //do something
            Benar();
            return;
        }

        if(number != QnA.QuestionAndAnswer[currentQuestion].CorrectAnswer)
        {
            //do something
            Salah();
            return;
        }
    }

    private void Benar()
    {
        benar += 1;

        Hasil.text = "Benar!";
        Debug.Log("BENERRR");
        QuizPanel.SetActive(false);
        HasilScreen.SetActive(true);
        StartCoroutine(Wait(3));
        


        
    }

    private void Salah()
    {
        Hasil.text = "Salah!";
        Debug.Log("SALAHH");
        QuizPanel.SetActive(false);
        HasilScreen.SetActive(true);
        StartCoroutine(Wait(3));

        
    }

    void FirstToDo()
    {
        QnA = QuizDatabase.instance.question.QNA[QuizDatabase.instance.QuestionIndex];
        generateQuestion();
    }
    void generateQuestion()
    {
        
        if (QnA.QuestionAndAnswer.Count > 0)
        {
            QuizPanel.SetActive(true);
            currentQuestion = Random.Range(0, QnA.QuestionAndAnswer.Count);

            soal.text = QnA.QuestionAndAnswer[currentQuestion].Question;
            SetAnswers();
        }

        if (QnA.QuestionAndAnswer.Count <= 0)
        {
            QuizPanel.SetActive(false);
            SelesaiPanel.SetActive(true);
            BenarText.text = benar+"/3";
            Debug.Log("SoalHabis");

        }

    }

    void SetAnswers()
    {
        for (int i = 0; i < QnA.QuestionAndAnswer.Count; i++)
        {
            A.text = QnA.QuestionAndAnswer[currentQuestion].Answers[0];
            B.text = QnA.QuestionAndAnswer[currentQuestion].Answers[1];
            C.text = QnA.QuestionAndAnswer[currentQuestion].Answers[2];
            D.text = QnA.QuestionAndAnswer[currentQuestion].Answers[3];
            jawaban = QnA.QuestionAndAnswer[currentQuestion].CorrectAnswer;
            /*
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }*/
        }
    }

    public void Next()
    {
        QnA.QuestionAndAnswer.RemoveAt(currentQuestion);
        Number += 1;
        generateQuestion();
    }


    IEnumerator Wait(float how)
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(how);
        HasilScreen.SetActive(false);
        Next();
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
