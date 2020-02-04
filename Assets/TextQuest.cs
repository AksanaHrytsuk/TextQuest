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

    [TextArea(minLines: 10, maxLines: 20)] public string mainText = "Take your chance play the games";
    // Start is called before the first frame update
    void Start()
    {
        titleText.text = title;
        textOfTheGame.text = mainText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
