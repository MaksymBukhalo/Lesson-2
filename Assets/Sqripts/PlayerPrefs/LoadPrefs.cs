using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPrefs : MonoBehaviour
{
    public int intNum = 0;
    public float floatNum= 0f;
    public string Name = "";

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            if(PlayerPrefs.HasKey("NumInt") && PlayerPrefs.HasKey("NumFloat") && PlayerPrefs.HasKey("NumString"))
            {
                intNum = PlayerPrefs.GetInt("NumInt");
                floatNum = PlayerPrefs.GetFloat("NumFloat");
                Name = PlayerPrefs.GetString("NumString");
                Debug.Log("Load");
            }
            else
            {
                intNum = 0;
                floatNum = 0f;
                Name = "";
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
            Debug.Log("Delete");
        }

        
    }
}
