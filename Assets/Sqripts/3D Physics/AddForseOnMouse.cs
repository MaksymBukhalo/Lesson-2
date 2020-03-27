using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForseOnMouse : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 100,ForceMode.VelocityChange);
        GetComponent<Rigidbody>().useGravity = true;
    }
}
