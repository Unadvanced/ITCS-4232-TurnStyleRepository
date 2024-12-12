using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCompleteCPU : MonoBehaviour
{
    public GameObject lapCompleteTriggerCPU;
    public GameObject lapHalfwayTriggerCPU;
    public GameObject raceFinishCPU;
    public static int lapCurrentCPU = 1;

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "CPUcar")
        {
            lapCurrentCPU += 1;
            lapCompleteTriggerCPU.SetActive(false);
            lapHalfwayTriggerCPU.SetActive(true);
        }
    }
}
