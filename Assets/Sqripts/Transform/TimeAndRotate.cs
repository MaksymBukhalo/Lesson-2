using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndRotate : MonoBehaviour
{
    float GameSeconds = 0f;
    float GameMinutes = 0f;

    public Text TextTimeAndRotate;
    void Update()
    {
        GameSeconds = GameSeconds + Time.deltaTime;

        TextTimeAndRotate.text = "Time " + GameMinutes + ":" + GameSeconds;
        
        if(GameSeconds >=60)
        {
            GameMinutes += 1;
            GameSeconds = 0;
        }       
    }
}
