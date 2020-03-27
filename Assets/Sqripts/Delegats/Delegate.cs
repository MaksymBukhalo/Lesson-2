using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    delegate void MyDelegate(int num);
    MyDelegate myDelegate;

    private void Start()
    {
        myDelegate = PrintNum;
        myDelegate(50);
        myDelegate = DoubleNum;
        myDelegate(60);
    }

    private void PrintNum(int num)
    {
        print("Print num: "+ num);
    }

    private void DoubleNum(int num)
    {
        print("Double num: " + 2*num);
    }
}
