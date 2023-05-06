using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class QuestionAndAnswer
{
    [TextArea]
    public string Question;
    public string[] Answers;
    public int CorrectAnswer;
}

[Serializable]
public class QNA
{
    public List<QuestionAndAnswer> QuestionAndAnswer;
}

[Serializable]
public class QuestionDB
{
    public List<QNA> QNA;
}
