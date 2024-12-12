using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColorChoice : MonoBehaviour
{
     // PLAYER: 1 = Red, 2 = Blue
     // CPU: 1 = Blue, 2 = Red
    public GameObject redBody;
    public GameObject redBodyCPU;
    public GameObject blueBody;
    public GameObject blueBodyCPU;
    public int carImport;
    void Start()
    {
        carImport = GlobalCar.carColor;
        if(carImport == 1)
        {
            redBody.SetActive(true);
            blueBodyCPU.SetActive(true);
        }
        
        if(carImport == 2)
        {
            blueBody.SetActive(true);
            redBodyCPU.SetActive(true);
        }
    }
}
