using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StandartEvent : MonoBehaviour
{
    public event Action standartEvent = delegate { };

    public void MouseDown()
    {
        standartEvent += ConsoleHi;
        standartEvent.Invoke();
        standartEvent -= ConsoleHi;
    }
    public void MouseDown2()
    {
        standartEvent += ConsoleHi;
        standartEvent.Invoke();
        standartEvent += ConsoleHi;
        standartEvent.Invoke();
    }

    public void ConsoleHi()
    {
        Debug.Log("Hi");
    }
}
