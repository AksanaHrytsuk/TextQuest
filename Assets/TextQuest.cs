﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    [Header("Elements")]
    public Text titleText;
    public Text textOfTheGame;
    [Header("Config")]
    [Tooltip("Название игры")] public string title = "Hello world";


    // Start is called before the first frame update
    public Step activeStep;
    void Start()
    {
        titleText.text = title;
        //  textOfTheGame.text = mainText;
        textOfTheGame.text = activeStep.mainText;

        //    int[] numbers = { 1, 3, 7, 8, 2 };
        //    numbers[2] = 6;
        //    Debug.Log(numbers);

        //    string[] days = { "пн", "вт", "ср", "чт", "пт", "суб", "вс" };
        //    Debug.Log(days[5]);

        //    Debug.Log(days.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            activeStep = activeStep.nextSteps[0];
            textOfTheGame.text = activeStep.mainText;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (activeStep.nextSteps.Length > 1)
            {


                activeStep = activeStep.nextSteps[1];
                textOfTheGame.text = activeStep.mainText;
            }
        }


    }
    void chekPress(int index)
    { 
        if (activeStep.nextSteps.Length > index)
        {
        if (activeStep.nextSteps[index] != null)
        {    
        activeStep = activeStep.nextSteps[1];
        textOfTheGame.text = activeStep.mainText;
        }
     }
}