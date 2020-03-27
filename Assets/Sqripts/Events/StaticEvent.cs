using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StaticEvent : MonoBehaviour
{
    public static event Action StatEvent = delegate { };

    public void MouseDown()
    {
        StatEvent += ConsoleHi;
        StatEvent.Invoke();
        StatEvent -= ConsoleHi;
        StatEvent.Invoke();
    }
    public void MouseDown2()
    {
        StatEvent += ConsoleHi;
        StatEvent.Invoke();
        StatEvent += ConsoleHi;
        StatEvent.Invoke();
    }

    public void ConsoleHi()
    {
        Debug.Log("Hello");
    }
}
