using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDistance : MonoBehaviour
{
    public float rayDistance = 50f;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, ray.direction * rayDistance,Color.red);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray,out hit))
            {
                Debug.Log("Shoot Create " + hit.transform.position );
                Debug.DrawLine(transform.position, hit.transform.position,Color.green, 2f);
            }
        }
    }
}
