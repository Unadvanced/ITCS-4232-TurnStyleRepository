using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject playerCar;
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
    public GameObject cpuCompleteTrigger;
    public GameObject cpuHalfTrigger;
    public GameObject cpuFinishTrigger;

    float topSpeed = UnityStandardAssets.Vehicles.Car.CarController.m_Topspeed;

    public void Start()
    {
        var carControllerActivate = playerCar.GetComponent<CarController>();
        var carUserControlActivate = playerCar.GetComponent<CarUserControl>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag != "CPUcar")
        {
            cpuCompleteTrigger.SetActive(false);
            cpuHalfTrigger.SetActive(false);
            cpuFinishTrigger.SetActive(false);
            raceFinishTrigger.SetActive(false);
            this.GetComponent<BoxCollider>().enabled = false;
            finishCamera.SetActive(true);
            viewModes.SetActive(false);
            completeTrigger.SetActive(false);
            fadeManager.SetActive(true);

            

            levelMusic.SetActive(false);
            finishMusic.Play();
            var fadeComponent = raceFinishTrigger.GetComponent<FadeToBlack>();
            fadeComponent.enabled = true;
            lapUI.SetActive(false);
            timerUI.SetActive(false);
            minimapUI.SetActive(false);
            positionUI.SetActive(false);

            // var carController = playerCar.GetComponent<CarController>();
            // var carUserControl = playerCar.GetComponent<CarUserControl>();

            // if(carController == true)
            // {
            //     carController.enabled = false;
            // }

            // if(carController == true)
            // {
            //     carUserControl.enabled = false;
            // }
        }
    }
}
