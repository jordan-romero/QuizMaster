using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;

    [SerializeField] GameObject[] answerButtons;


    // Start is called before the first frame update
    void Start()
    {
        questionText.text = question.GetQuestion();

        TextMeshProUGUI buttonText = answerButtons[0].GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = question.GetAnswer(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
