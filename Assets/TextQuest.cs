using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    [Header("Elements")]
    public Text titleText;
    public Text contentText;
    [Header("Config")]
    [Tooltip("Название игры")] public string title = "let's get it started!";

    [TextArea(minLines: 10, maxLines: 20)] public string mainText = "Would you like playing the game?";
    // Start is called before the first frame update
    void Start()
    {
        titleText.text = title;
        contentText.text = mainText;
    }

    // Update is called once per frames
    void Update()
    {
        
    }
}
