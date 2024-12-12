using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int minuteCount;
    public static int secondCount;
    public static float millisecondCount;
    public static string millisecondDisplay;

    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject millisecondBox;

    public static float rawTime;

    void Update()
    {
        millisecondCount += Time.deltaTime * 10;
        rawTime += Time.deltaTime;
        millisecondDisplay = millisecondCount.ToString();
        millisecondBox.GetComponent<Text>().text = "" + millisecondDisplay;

        if (millisecondCount >= 10)
        {
            millisecondCount = 0;
            secondCount += 1;
        }

        if (secondCount <= 9)
        {
            secondBox.GetComponent<Text>().text = "0" + secondCount + ".";
        }
        else
        {
            secondBox.GetComponent<Text>().text = "" + secondCount + ".";
        }

        if (secondCount >= 60)
        {
            secondCount = 0;
            minuteCount += 1;
        }

        if (minuteCount <= 9)
        {
            minuteBox.GetComponent<Text>().text = "0" + minuteCount + ":";
        }
        else
        {
            minuteBox.GetComponent<Text>().text = "" + minuteCount + ":";
        }
    }
}
