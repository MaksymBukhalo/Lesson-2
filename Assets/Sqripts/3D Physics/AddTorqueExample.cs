using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorqueExample : MonoBehaviour
{
    float amount = 50f;
    public Rigidbody body = new Rigidbody();

    private void FixedUpdate()
    {
        float horizont = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * amount * Time.deltaTime;
        body.AddTorque(transform.up * horizont,ForceMode.VelocityChange);
        body.AddTorque(transform.right * vertical,ForceMode.VelocityChange);
    }
}
