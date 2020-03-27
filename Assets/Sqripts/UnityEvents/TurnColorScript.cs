using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{

    private void OnEnable()
    {
        EventManager.ClickedButton += TurnColor;
    }

    private void OnDisable()
    {
        EventManager.ClickedButton -= TurnColor;
    }

    private void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}
