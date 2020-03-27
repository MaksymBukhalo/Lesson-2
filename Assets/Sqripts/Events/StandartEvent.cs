using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StandartEvent : MonoBehaviour
{
    public event Action StandartEvents = delegate { };

    public void MouseDown()
    {
        StandartEvents += ConsoleHi;
        StandartEvents.Invoke();
        StandartEvents -= ConsoleHi;
    }

    public void MouseDown2()
    {
        StandartEvents += ConsoleHi;
        StandartEvents.Invoke();
        StandartEvents += ConsoleHi;
        StandartEvents.Invoke();
    }

    public void ConsoleHi()
    {
        Debug.Log("Hi");
    }
}
