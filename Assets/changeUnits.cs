using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
using TMPro;


public class changeUnits : MonoBehaviour
{
    // Start is called before the first frame update
    public getTime getTimeObject; 
    public getDate getDateObject;
    public GameObject buttonObject;
    public GameObject buttonTextObject;
    public static int isMetric; 
    void Start()
    {
        buttonObject = GameObject.Find("ChangeUnitsButton");
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        isMetric = 0;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
        if (isMetric == 0) {
            isMetric = 1;
            buttonTextObject.GetComponent<TextMeshPro>().text = "Change to Imperial Units";
            getTimeObject.callUpdate();
            getDateObject.callUpdate();
        }
        else {
            isMetric = 0;
            buttonTextObject.GetComponent<TextMeshPro>().text = "Change to Metric Units";
            getTimeObject.callUpdate();
            getDateObject.callUpdate();
        }
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
