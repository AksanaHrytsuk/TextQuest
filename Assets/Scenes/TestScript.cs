using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public Button btn;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        Text btnText = btn.GetComponentInChildren<Text>();
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            btnText.text = "Number";
        }
          
    }
}
