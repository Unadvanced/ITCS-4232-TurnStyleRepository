using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject countdown;
    public AudioSource getReady;
    public AudioSource goAudio;
    public GameObject lapTimer;
    public GameObject carControls;

    public GameObject lapHalfTrigger;
    public GameObject lapHalfTriggerCPU;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        lapHalfTrigger.SetActive(true);
        lapHalfTriggerCPU.SetActive(true);
        LapComplete.lapCurrent = 1;
        LapCompleteCPU.lapCurrentCPU = 1;
        AudioListener.volume = 1;
        yield return new WaitForSeconds(0.5f);
        countdown.GetComponent<Text>().text = "3";
        getReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "2";
        getReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "1";
        getReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        goAudio.Play();
        lapTimer.GetComponent<LapTimeManager>().enabled = true;
        carControls.SetActive(true);
    }
}
