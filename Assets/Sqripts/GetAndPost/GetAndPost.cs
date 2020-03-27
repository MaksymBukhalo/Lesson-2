using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetAndPost : MonoBehaviour
{
    public string Json;

    public void GetWebsite()
    {
        StartCoroutine(IGetSite());
    }

    public void PostWebsite()
    {
        StartCoroutine(IPostSite());
    }

    IEnumerator IGetSite()
    {
        UnityWebRequest website = UnityWebRequest.Get("https://postman-echo.com/get?foo1=bar1");
        yield return website.SendWebRequest();
        Json = website.downloadHandler.text;
        Debug.Log(Json);
    }

    IEnumerator IPostSite()
    {
        Debug.Log(Json);
        List<IMultipartFormSection> websiteForms = new List<IMultipartFormSection>();
        UnityWebRequest website = UnityWebRequest.Post("https://postman-echo.com/post", Json);
        yield return website.SendWebRequest();
    }

}
