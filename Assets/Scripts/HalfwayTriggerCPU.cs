using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayTriggerCPU : MonoBehaviour
{
    public GameObject lapCompleteTrigger;
    public GameObject lapHalfTrigger;
    public GameObject raceFinishTrigger;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "CPUcar")
        {
            lapCompleteTrigger.SetActive(true);
            lapHalfTrigger.SetActive(false);
            var cpuLapCount = LapCompleteCPU.lapCurrentCPU;
            Debug.Log("CPU Lap count: " + cpuLapCount);
            if (LapCompleteCPU.lapCurrentCPU == 3)
            {
                raceFinishTrigger.SetActive(true);
                lapHalfTrigger.SetActive(false);
            }
        }
    }
}
