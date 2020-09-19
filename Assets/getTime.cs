using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class getTime : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject timeTextObject;
    public string formattedString;
    public int getUnits;

    void Start()
    {   
        InvokeRepeating("UpdateTime", 0f, 30f);
    }

    public void callUpdate() {
        UpdateTime();
    }

    // Update is called once per frame
    void UpdateTime()
    {
        getUnits = changeUnits.isMetric;
        if (getUnits == 1) {
            formattedString = "HH:mm";
        }
        else {
            formattedString = "hh:mm tt";
        }
        timeTextObject.GetComponent<TextMeshPro>().text = System.DateTime.Now.ToString(formattedString);
    }
}
