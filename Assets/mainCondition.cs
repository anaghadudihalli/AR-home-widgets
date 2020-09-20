using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCondition : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clear;
    public GameObject fewClouds;
    public GameObject scatteredClouds;
    public GameObject brokenClouds;
    public GameObject showerRain;
    public GameObject rain;
    public GameObject thunderstorm;
    public GameObject mist;
    public GameObject snow;
    public int indexNo;

    void Start()
    {
        makeAllInactive();
        InvokeRepeating("UpdateMainCondition", 5f, 30f);
    }

    void makeAllInactive() {
        clear.SetActive(false);
        fewClouds.SetActive(false);
        scatteredClouds.SetActive(false);
        brokenClouds.SetActive(false);
        showerRain.SetActive(false);
        rain.SetActive(false);
        thunderstorm.SetActive(false);
        mist.SetActive(false);
        snow.SetActive(false);
    }

    // Update is called once per frame
    void UpdateMainCondition()
    {
        makeAllInactive();
        indexNo = getWeather.condition;
        if(indexNo == 1) {
            clear.SetActive(true);
        }
        else if (indexNo == 2) {
            fewClouds.SetActive(true);
        }
        else if (indexNo == 3) {
            scatteredClouds.SetActive(true);
        }
        else if (indexNo == 4) {
            brokenClouds.SetActive(true);
        }
        else if (indexNo == 5) {
            showerRain.SetActive(true);
        }
        else if (indexNo == 6) {
            rain.SetActive(true);
        }
        else if (indexNo == 7) {
            thunderstorm.SetActive(true);
        }
        else if (indexNo == 8) {
            mist.SetActive(true);
        }
        else if (indexNo == 9) {
            snow.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            makeAllInactive();
            if (indexNo == 1) {
                indexNo = 9;
            }
            else {
                indexNo --;
            }
            if(indexNo == 1) {
                clear.SetActive(true);
            }
            else if (indexNo == 2) {
                fewClouds.SetActive(true);
            }
            else if (indexNo == 3) {
                scatteredClouds.SetActive(true);
            }
            else if (indexNo == 4) {
                brokenClouds.SetActive(true);
            }
            else if (indexNo == 5) {
                showerRain.SetActive(true);
            }
            else if (indexNo == 6) {
                rain.SetActive(true);
            }
            else if (indexNo == 7) {
                thunderstorm.SetActive(true);
            }
            else if (indexNo == 8) {
                mist.SetActive(true);
            }
            else if (indexNo == 9) {
                snow.SetActive(true);
            }
            print("up arrow key is held down");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            makeAllInactive();
            if (indexNo == 9) {
                indexNo = 1;
            }
            else {
                indexNo ++;
            }
            if(indexNo == 1) {
                clear.SetActive(true);
            }
            else if (indexNo == 2) {
                fewClouds.SetActive(true);
            }
            else if (indexNo == 3) {
                scatteredClouds.SetActive(true);
            }
            else if (indexNo == 4) {
                brokenClouds.SetActive(true);
            }
            else if (indexNo == 5) {
                showerRain.SetActive(true);
            }
            else if (indexNo == 6) {
                rain.SetActive(true);
            }
            else if (indexNo == 7) {
                thunderstorm.SetActive(true);
            }
            else if (indexNo == 8) {
                mist.SetActive(true);
            }
            else if (indexNo == 9) {
                snow.SetActive(true);
            }
            print("down arrow key is held down");
        }
    }
}
