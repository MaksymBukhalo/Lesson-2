using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountBounce : MonoBehaviour
{
    
    public Text countAndDistance;
    public GameObject plane;

    private float distance = 0f;
    private int countPlane = 0;
    private int countCube = 0;

    private void OnCollisionEnter(Collision collision)
    {
        countPlane++;
    }

    private void OnTriggerExit(Collider other)
    {
        countCube++;
    }

    private void FixedUpdate()
    {
        distance = transform.position.y - plane.transform.position.y;
        countAndDistance.text = "CountPlane " + countPlane + " CountCube " + countCube + "\nDistance " + distance;
    }
}
