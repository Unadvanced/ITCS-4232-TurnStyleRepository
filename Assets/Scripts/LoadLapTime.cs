using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int minCount;
    public int secCount;
    public float millicount;
    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject millisecondDisplay;

    void Start()
    {
        minCount = PlayerPrefs.GetInt("MinuteSave");
        secCount = PlayerPrefs.GetInt("SecondSave");
        millicount = PlayerPrefs.GetFloat("MillisecondSave");

        minuteDisplay.GetComponent<Text>().text = "" + minCount + ":";
        secondDisplay.GetComponent<Text>().text = "" + secCount + ".";
        millisecondDisplay.GetComponent<Text>().text = "" + millicount;
    }
}
