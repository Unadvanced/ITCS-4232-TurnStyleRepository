using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarSelectSpin : MonoBehaviour
{
    public GameObject redCarSpin;
    public GameObject blueCarSpin;
    
    public void Update()
    {
        redCarSpin.transform.Rotate(0f, 10f * Time.deltaTime, 0f, Space.Self);
        blueCarSpin.transform.Rotate(0f, -10f * Time.deltaTime, 0f, Space.Self);
    }
}
