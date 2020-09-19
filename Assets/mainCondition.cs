using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCondition : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cat;
    void Start()
    {
        InvokeRepeating("UpdateCat", 10f, 10f);
    }

    // Update is called once per frame
    void UpdateCat()
    {
        cat.SetActive(false);
    }
}
