using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using Newtonsoft.Json.Linq;

public class getWeather : MonoBehaviour
{
    // Start is called before the first frame update
    string url_imperial = "http://api.openweathermap.org/data/2.5/weather?lat=41.88&lon=-87.6&APPID=ee20a9afd0989739bce46c9b270b0151&units=imperial";
    string url_metric = "http://api.openweathermap.org/data/2.5/weather?lat=41.88&lon=-87.6&APPID=ee20a9afd0989739bce46c9b270b0151&units=metric";
    // public GameObject tempTextObject;
    void Start()
    {
        InvokeRepeating("GetDataFromWeb", 2f, 900f);
    }

    // Update is called once per frame
    void GetDataFromWeb()
   {
       StartCoroutine(GetRequest(url_imperial));
   }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            if (webRequest.isNetworkError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                // print out the weather data to make sure it makes sense
                Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);

                var results = JObject.Parse(webRequest.downloadHandler.text);
                var mainCondition = (string)results["name"];
                Debug.Log(mainCondition);
            }
        }
    }
}
