using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDot : MonoBehaviour
{
    public Vector3 endPosition;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPosition, Time.deltaTime);
    }
}
