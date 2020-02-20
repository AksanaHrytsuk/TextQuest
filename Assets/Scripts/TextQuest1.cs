using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest1 : MonoBehaviour
{
  public Data dataAsset; 
  [Header("Elements")]
  public Text titleText;
  public Text textOfTheGame;
  [Header("Config")]
  [Tooltip("Название игры")] public string title = "Hello world";


  // Start is called before the first frame update
  public StepData activeStep;
  public Image contentImage;
  void Start()
  {
    titleText.text = title;
    textOfTheGame.text = activeStep.mainText;
        //  textOfTheGame.text = mainText;

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
        checkPress(0);
    }
    if (Input.GetKeyDown(KeyCode.Alpha2))
    {
        checkPress(1);
    }


  }
  void checkPress(int index)
  {
    if (activeStep.nextSteps.Length > index)
    {
      if (activeStep.nextSteps[index] != null)
      {
        activeStep = activeStep.nextSteps[index];
        textOfTheGame.text = activeStep.mainText;
      }
    }
  }
} 