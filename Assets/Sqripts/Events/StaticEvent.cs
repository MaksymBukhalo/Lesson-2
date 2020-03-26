using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StaticEvent : MonoBehaviour
{
    public static event Action statEvent = delegate { };

    public void MouseDown()
    {
        statEvent += ConsoleHi;
        statEvent.Invoke();
        statEvent -= ConsoleHi;
        statEvent.Invoke();
    }
    public void MouseDown2()
    {
        statEvent += ConsoleHi;
        statEvent.Invoke();
        statEvent += ConsoleHi;
        statEvent.Invoke();
    }

    public void ConsoleHi()
    {
        Debug.Log("Hello");
    }
}
