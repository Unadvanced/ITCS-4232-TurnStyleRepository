using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFinishCPU : MonoBehaviour
{
    public GameObject finishCamera;
    public GameObject viewModes;
    public GameObject levelMusic;
    public GameObject completeTrigger;
    public AudioSource finishMusic;
    public GameObject raceFinishTrigger;
    public GameObject fadeManager;
    public GameObject lapUI;
    public GameObject timerUI;
    public GameObject minimapUI;
    public GameObject positionUI;
    public GameObject playerCompleteTrigger;
    public GameObject playerHalfTrigger;
    public GameObject playerFinishTrigger;

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "CPUcar")
        {
            playerCompleteTrigger.SetActive(false);
            playerHalfTrigger.SetActive(false);
            playerFinishTrigger.SetActive(false);
            raceFinishTrigger.SetActive(false);
            this.GetComponent<BoxCollider>().enabled = false;
            finishCamera.SetActive(true);
            viewModes.SetActive(false);
            completeTrigger.SetActive(false);
            fadeManager.SetActive(true);
            levelMusic.SetActive(false);
            finishMusic.Play();
            lapUI.SetActive(false);
            timerUI.SetActive(false);
            minimapUI.SetActive(false);
            positionUI.SetActive(false);
        }
    }
}
