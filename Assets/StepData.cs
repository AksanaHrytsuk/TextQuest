using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Steps")]
public class StepData : ScriptableObject
{
    [TextArea(minLines: 10, maxLines: 20)] public string mainText = "Take your chance play the games";


    public StepData[] nextSteps;
    public Color stepColor;
}
