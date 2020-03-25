using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadeResources : MonoBehaviour
{
    Dictionary<string, GameObject> cubeByName;
    public void LoadAll()
    {
        cubeByName = new Dictionary<string, GameObject>();
        foreach (var cube in Resources.LoadAll<GameObject>("Cube"))
        {
            cubeByName.Add(cube.name, cube);
        }
    }

    public GameObject GetCubePrefab(string name)
    {
        if(!cubeByName.ContainsKey(name))
        {
            Debug.LogError(string.Format("ERROR! Cube whith name '{0}' no found", name));
        }
        return cubeByName[name];
    }
}