﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using Newtonsoft.Json.Linq;

public class weatherScript : MonoBehaviour
{
    // Start is called before the first frame update
    string urlImperial = "http://api.openweathermap.org/data/2.5/weather?lat=41.88&lon=-87.6&APPID=ee20a9afd0989739bce46c9b270b0151&units=imperial";
    string urlMetric = "http://api.openweathermap.org/data/2.5/weather?lat=41.88&lon=-87.6&APPID=ee20a9afd0989739bce46c9b270b0151&units=metric";
    string url = "";
    string temperatureUnit = "";
    string windSpeedUnit = "";
    public TextMeshPro tempTextObject;
    public TextMeshPro humidityTextObject;
    public TextMeshPro windTextObject;
    public int getUnits;
    void Start()
    {
        InvokeRepeating("GetDataFromWeb", 0f, 30f);
    }

    public void callUpdate() {
        GetDataFromWeb();
    }
    // Update is called once per frame
    void GetDataFromWeb()
   {
        getUnits = changeUnits.isMetric;
        if (getUnits == 1){
            url = urlMetric;
        }
        else {
            url = urlImperial;
        }
        StartCoroutine(GetRequest(url, getUnits));
   }

    IEnumerator GetRequest(string uri, int getUnits)
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
                if (getUnits == 1){
                    temperatureUnit = "C";
                    windSpeedUnit = "m/s";
                }
                else {
                    temperatureUnit = "F";
                    windSpeedUnit = "mi/h";
                }
                var results = JObject.Parse(webRequest.downloadHandler.text);
                tempTextObject.GetComponent<TextMeshPro>().text = (string)results["main"]["temp"] + " " + temperatureUnit;
                humidityTextObject.GetComponent<TextMeshPro>().text = (string)results["main"]["humidity"] + " %";
                int windSpeed = (int)results["wind"]["speed"];
                int windDeg = (int)results["wind"]["deg"];
                string windDirection = "";

                if (windDeg > 349 && windDeg < 11) {
                    windDirection = "N";
                } else if(windDeg > 12 && windDeg < 33) {
                    windDirection = "NNE";
                } else if(windDeg > 34 && windDeg < 56) {
                    windDirection = "NE";
                } else if(windDeg > 57 && windDeg < 78) {
                    windDirection = "ENE";
                } else if(windDeg > 79 && windDeg < 101) {
                    windDirection = "E";
                } else if(windDeg > 102 && windDeg < 123) {
                    windDirection = "ESE";
                } else if(windDeg > 124 && windDeg < 146) {
                    windDirection = "SE";
                } else if(windDeg > 147 && windDeg < 168) {
                    windDirection = "SSE";
                } else if(windDeg > 169 && windDeg < 191) {
                    windDirection = "S";
                } else if(windDeg > 192 && windDeg < 213) {
                    windDirection = "SSW";
                } else if(windDeg > 214 && windDeg < 236) {
                    windDirection = "SW";
                } else if(windDeg > 237 && windDeg < 258) {
                    windDirection = "WSW";
                } else if(windDeg > 259 && windDeg < 281) {
                    windDirection = "W";
                } else if(windDeg > 282 && windDeg < 303) {
                    windDirection = "WNW";
                } else if(windDeg > 304 && windDeg < 326) {
                    windDirection = "NW";
                } else if(windDeg > 327 && windDeg < 348) {
                    windDirection = "NNW";
                }
                windTextObject.GetComponent<TextMeshPro>().text = windSpeed.ToString() + " " + windSpeedUnit + " " + windDirection;
            }
        }
    }
}
