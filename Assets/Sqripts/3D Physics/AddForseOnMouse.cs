using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForseOnMouse : MonoBehaviour
{
    void OnMouseDown()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        body.AddForce(transform.forward * 100,ForceMode.VelocityChange);
        body.useGravity = true;
    }
}
