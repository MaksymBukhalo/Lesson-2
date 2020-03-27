using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorqueExample : MonoBehaviour
{
    private float amount = 50f;

    private void FixedUpdate()
    {
        float horizont = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * amount * Time.deltaTime;
        GetComponent<Rigidbody>().AddTorque(transform.up * horizont,ForceMode.VelocityChange);
        GetComponent<Rigidbody>().AddTorque(transform.right * vertical,ForceMode.VelocityChange);
    }
}
