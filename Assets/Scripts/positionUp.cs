using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class positionUp : MonoBehaviour
{
    public TextMeshProUGUI positionDisplay;

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "playerPosition")
        {
            positionDisplay.text = "1st";
        }
    }
}
