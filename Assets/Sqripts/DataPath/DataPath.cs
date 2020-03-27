using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPath : MonoBehaviour
{

    private void Start()
    {
        Debug.Log("Dateipafad: " + Application.persistentDataPath);
    }

}
