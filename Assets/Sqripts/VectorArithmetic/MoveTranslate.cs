using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTranslate : MonoBehaviour
{
    public Vector3 vectorMove;
    public float speedCapsule;

    void Update()
    {
        transform.Translate(vectorMove.normalized * speedCapsule);
    }
}
