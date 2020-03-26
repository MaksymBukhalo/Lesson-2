using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastDelegate : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myDelegate;
    void Start()
    {
        myDelegate += PowerUp;
        myDelegate += TurnRed;
        myDelegate();
    }
    private void PowerUp()
    {
        Debug.Log("Power up");
    }
    private void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
