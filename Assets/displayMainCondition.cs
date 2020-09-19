using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayMainCondition : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject brokenClouds;
    // public GameObject clear;
    // public GameObject fewClouds;
    // public GameObject mist;
    // public GameObject rain;
    // public GameObject ScatteredClouds;
    // public GameObject showerRain;
    // public GameObject thunderStorm;
    // public GameObject cloud;
    // public GameObject mainC;
    public int indexNo=0;
    public int firstTime = 1;
    void Start()
    {
        // InvokeRepeating("UpdateMainCondition", 5f, 10f);
        Debug.Log("inside start");
        // while (getWeather.mainCondition == 0) {
        //     Debug.Log("is null");
        // }

        // if (getWeather.mainCondition == 1) {
        //     Debug.Log("work plz");
        // }

        // Debug.Log("is not null");
        // // Debug.Log(getWeather.mainCondition.ToString());
        // mainC = Instantiate(cloud, transform.position, Quaternion.identity, transform.parent);
    }

    // Update is called once per frame
    void UpdateMainCondition()
    {
        // indexNo = getWeather.mainCondition;
        // mainC.setActive(false);
        // Update();
    }

    void Update() {
        // Debug.Log("disabling");
        // mainC.setActive(false);
    }

    //     bool left = Input.GetKeyDown(KeyCode.LeftArrow);
    //     bool right = Input.GetKeyDown(KeyCode.RightArrow);
    //     Debug.Log("Called");
    //     //Detect when the up arrow key is pressed down
    //     if (left) {
    //         Debug.Log("left pressed");
    //         if(indexNo == 1){
    //             indexNo = 8;
    //         }
    //         else {
    //             indexNo --;
    //         }
    //     }

    //     //Detect when the up arrow key has been released
    //     if (right){
    //         Debug.Log("right pressed");
    //         if(indexNo == 8){
    //             indexNo = 1;
    //         }
    //         else {
    //             indexNo ++;
    //         }
    //     }

    //     if (indexNo == 1) {
    //         if (firstTime != 1) {
    //             Destroy(mainC);
    //         } else {
    //             firstTime = 0;
    //         }
    //         mainC = Instantiate(clear, transform.position, Quaternion.identity, transform.parent);
    //     } 
    //     else if(indexNo == 2) {
    //         if (firstTime != 1) {
    //             Destroy(mainC);
    //         } else {
    //             firstTime = 0;
    //         }
    //         mainC = Instantiate(fewClouds, transform.position, Quaternion.identity, transform.parent);
    //     }
    //     else if(indexNo == 3) {
    //         if (firstTime != 1) {
    //             Destroy(mainC);
    //         } else {
    //             firstTime = 0;
    //         }
    //         mainC = Instantiate(ScatteredClouds, transform.position, Quaternion.identity, transform.parent);
    //     }
    //     else if(indexNo == 4) {
    //         if (firstTime != 1) {
    //             Destroy(mainC);
    //         } else {
    //             firstTime = 0;
    //         }
    //         mainC = Instantiate(brokenClouds, transform.position, Quaternion.identity, transform.parent);
    //     }
    //     else if(indexNo == 5) {
    //         if (firstTime != 1) {
    //             Destroy(mainC);
    //         } else {
    //             firstTime = 0;
    //         }
    //         mainC = Instantiate(showerRain, transform.position, Quaternion.identity, transform.parent);
    //     }
    //     else if(indexNo == 6) {
    //         if (firstTime != 1) {
    //             Destroy(mainC);
    //         } else {
    //             firstTime = 0;
    //         }
    //         mainC = Instantiate(rain, transform.position, Quaternion.identity, transform.parent);
    //     }
    //     else if(indexNo == 7) {
    //         if (firstTime != 1) {
    //             Destroy(mainC);
    //         } else {
    //             firstTime = 0;
    //         }
    //         mainC = Instantiate(thunderStorm, transform.position, Quaternion.identity, transform.parent);
    //     }
    //     else if(indexNo == 8) {
    //         if (firstTime != 1) {
    //             Destroy(mainC);
    //         } else {
    //             firstTime = 0;
    //         }
    //         mainC = Instantiate(mist, transform.position, Quaternion.identity, transform.parent);
    //     }
    // }
}
