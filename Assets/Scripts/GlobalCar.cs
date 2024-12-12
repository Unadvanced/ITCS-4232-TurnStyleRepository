using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int carColor; // 1 = Red, 2 = Blue
    public GameObject trackWindow;
    public GameObject carWindow;

    public void RedCar()
    {
        carColor = 1;
        carWindow.SetActive(false);
        trackWindow.SetActive(true);
    }

    public void BlueCar()
    {
        carColor = 2;
        carWindow.SetActive(false);
        trackWindow.SetActive(true);
    }
}
