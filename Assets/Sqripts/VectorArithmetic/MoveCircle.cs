using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircle : MonoBehaviour
{
    public float angle = 0; 
    public float radius = 0.5f;
    public float speed = 1f;
    public bool isCircle = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCircle)
        {
            angle += Time.deltaTime; 

            var x = Mathf.Cos(angle * speed) * radius;
            var y = Mathf.Sin(angle * speed) * radius;
            var z = Mathf.Cos(angle * speed) * radius;
            transform.position = new Vector3(x, y,z);
        }
    }
}
