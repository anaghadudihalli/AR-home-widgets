using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class getTime : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject timeTextObject;
    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 30f);
    }

    // Update is called once per frame
    void UpdateTime()
    {
        timeTextObject.GetComponent<TextMeshPro>().text = System.DateTime.Now.ToString("h:mm tt");
    }
}
