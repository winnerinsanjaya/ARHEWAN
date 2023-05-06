using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizDatabase : MonoBehaviour
{
    public static QuizDatabase instance;

    public QuestionDB question;

    public int QuestionIndex;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }

    }
}
