using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriger : MonoBehaviour
{
    public float hoverForse = 20f;
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
        other.attachedRigidbody.AddForce(Vector3.up * hoverForse, ForceMode.Acceleration);
    }
}
