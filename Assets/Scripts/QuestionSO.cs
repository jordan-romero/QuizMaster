using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "QuizQuestion", menuName = "QuizQuestion")]
public class QuestionSO : ScriptableObject {

    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question here";

    [SerializeField] string[] answers = new string[4];

    public string GetQuestion() {
        return question;
    }
}

