using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }

    public Renderer rend;
    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        rend.material.color = col;
    }
}
