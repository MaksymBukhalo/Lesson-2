using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter called");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay occuring...");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit called...");
    }
}
