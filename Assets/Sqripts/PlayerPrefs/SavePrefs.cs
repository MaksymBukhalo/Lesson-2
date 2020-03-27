using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("NumInt", 23);
        PlayerPrefs.SetFloat("NumFloat", 124f);
        PlayerPrefs.SetString("NumString", "Test Games");

        PlayerPrefs.Save();
        Debug.Log("Save");
    }
}
