using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForce : MonoBehaviour
{
    public Vector3 vectorMove;
    public float forseCapsule;

    void Update()
    {
        GetComponent<Rigidbody>().AddForce(vectorMove.normalized * forseCapsule);
    }
}
