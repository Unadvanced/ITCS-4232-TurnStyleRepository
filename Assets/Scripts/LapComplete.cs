using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject lapCompleteTrigger;
    public GameObject lapHalfTrigger;

    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject millisecondDisplay;

    public GameObject lapTimeBox;
    public GameObject lapCounter;
    public static int lapCurrent = 1;

    public float rawTime;

    public GameObject raceFinish;

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag != "CPUcar")
        {
            lapCurrent += 1;
            rawTime = PlayerPrefs.GetFloat("RawTime");
            if (LapTimeManager.rawTime <= rawTime)
            {
                if (LapTimeManager.secondCount <= 9)
                {
                    secondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ".";
                }
                else
                {
                    secondDisplay.GetComponent<Text>().text = "" + LapTimeManager.secondCount + ".";
                }

                if (LapTimeManager.minuteCount <= 9)
                {
                    minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ":";
                }
                else
                {
                    minuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.minuteCount + ":";
                }

                millisecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.millisecondCount;
            }

            PlayerPrefs.SetInt("MinuteSave", LapTimeManager.minuteCount);
            PlayerPrefs.SetInt("SecondSave", LapTimeManager.secondCount);
            PlayerPrefs.SetFloat("MillisecondSave", LapTimeManager.millisecondCount);
            PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);

            LapTimeManager.minuteCount = 0;
            LapTimeManager.secondCount = 0;
            LapTimeManager.millisecondCount = 0;
            LapTimeManager.rawTime = 0;
            lapCounter.GetComponent<Text>().text = "" + lapCurrent + " / 3";
            
            lapCompleteTrigger.SetActive(false);
            lapHalfTrigger.SetActive(true);
        }
    }
}
