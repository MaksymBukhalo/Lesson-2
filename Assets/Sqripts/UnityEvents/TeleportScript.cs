using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.ClickedButton += Teleport;
    }

    private void OnDisable()
    {
        EventManager.ClickedButton -= Teleport;
    }

    private void Teleport()
    {        
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
