using System.Collections;
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
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            textOfTheGame.text = "Вы попали в комнату 1";

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            textOfTheGame.text = "Вы попали в комнату 2";

        }

       
    }
}
