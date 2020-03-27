using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public float rotateSpeed = 360f;
    public int rotateX = 0;
    public int rotateY = 0;
    public int rotateZ = 0;

    private void Update()
    {
        Vector3 rotatePosihn = new Vector3(rotateX, rotateY, rotateZ);
        float angle = rotateSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(angle, rotatePosihn);       
    }
}
