using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayTrigger : MonoBehaviour
{
    public GameObject lapCompleteTrigger;
    public GameObject lapHalfTrigger;
    public GameObject raceFinishTrigger;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag != "CPUcar")
        {
            lapCompleteTrigger.SetActive(true);
            lapHalfTrigger.SetActive(false);
            if (LapComplete.lapCurrent == 3)
            {
                raceFinishTrigger.SetActive(true);
                lapHalfTrigger.SetActive(false);
            }

        }
    }

}
