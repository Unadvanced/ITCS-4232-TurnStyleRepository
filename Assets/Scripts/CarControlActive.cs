using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject carControl;
    public GameObject carControlCPU;
    void Update()
    {
        if(carControl != null || carControlCPU != null)
        {
            var carController = carControl.GetComponent<CarUserControl>();
            var carAIControl = carControlCPU.GetComponent<CarAIControl>();

            if(carController != null)
            {
                carController.enabled = true;
            }
            if(carAIControl != null)
            {
                carAIControl.enabled = true;
            }
        }

        // carControl.GetComponent<CarController>().enabled = true;
        // carControlCPU.GetComponent<CarAIControl>().enabled = true;
    }
}
