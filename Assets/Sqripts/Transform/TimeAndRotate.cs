using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndRotate : MonoBehaviour
{
    public Text textTimeAndRotate;

    private float gameSeconds = 0f;
    private float gameMinutes = 0f;

    private void Update()
    {
        gameSeconds = gameSeconds + Time.deltaTime;

        textTimeAndRotate.text = "Time " + gameMinutes + ":" + gameSeconds;
        
        if(gameSeconds >=60)
        {
            gameMinutes += 1;
            gameSeconds = 0;
        }       
    }
}
