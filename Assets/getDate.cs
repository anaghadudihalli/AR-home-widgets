using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class getDate : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro dateTextObject;
    public TextMeshPro dayTextObject;
    public TextMeshPro monthYearTextObject;
    
    void Start()
    {
        InvokeRepeating("UpdateDate", 0f, 30f);
    }

    // Update is called once per frame
    void UpdateDate()
    {
        dateTextObject.GetComponent<TextMeshPro>().text = System.DateTime.Now.ToString("dd");
        dayTextObject.GetComponent<TextMeshPro>().text = System.DateTime.Now.ToString("dddd");
        monthYearTextObject.GetComponent<TextMeshPro>().text = System.DateTime.Now.ToString("MMMM, yyyy");
    }
}
