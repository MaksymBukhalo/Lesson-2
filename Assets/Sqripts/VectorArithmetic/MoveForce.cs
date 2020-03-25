using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForce : MonoBehaviour
{
    public Vector3 VectorMove;
    public float forseCapsule;
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce(VectorMove.normalized * forseCapsule);
    }
}
