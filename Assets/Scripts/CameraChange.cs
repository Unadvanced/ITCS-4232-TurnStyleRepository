using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject defaultCamera;
    public GameObject rearCamera;
    public int cameraMode; // 1 = Default, 2 = Rear
    void Update()
    {
        if(Input.GetButton("Viewmode"))
        {
            cameraMode = 2;
        } else {
            cameraMode = 1;
        }
        StartCoroutine(ModeChange());
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(cameraMode == 1)
        {
            defaultCamera.SetActive(true);
            rearCamera.SetActive(false);
        } else {
            defaultCamera.SetActive(false);
            rearCamera.SetActive(true);
        }
    }
}
