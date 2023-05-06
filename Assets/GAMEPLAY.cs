using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMEPLAY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Elephant()
    {
        Debug.Log("There is Elephant");
    }


    public void Tiger()
    {
        Debug.Log("There is Tiger");
    }

    public void Wolf()
    {
        Debug.Log("There is Wolf");
    }

    public void Whale()
    {
        Debug.Log("There is Whale");
    }

    public void TrackedOff()
    {
        Debug.Log("TrackedOff");
    }

    public void GoToQuiz(int QuizIndex)
    {
        QuizDatabase.instance.QuestionIndex = QuizIndex;
        SceneManager.LoadScene("QUIZ");

    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
