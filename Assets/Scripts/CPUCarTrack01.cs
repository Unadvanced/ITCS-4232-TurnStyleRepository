using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUCarTrack01 : MonoBehaviour
{
    public GameObject theMarker;
    public GameObject point01;
    public GameObject point02;
    public GameObject point03;
    public GameObject point04;
    public GameObject point05;
    public GameObject point06;
    public GameObject point07;
    public GameObject point08;
    public GameObject point09;
    public GameObject point10;
    public GameObject point11;
    public GameObject point12;
    public GameObject point13;
    public int markTracker;
    void Update()
    {
        if(markTracker == 0)
        {
            theMarker.transform.position = point01.transform.position;
        }
        if(markTracker == 1)
        {
            theMarker.transform.position = point02.transform.position;
        }
        if(markTracker == 2)
        {
            theMarker.transform.position = point03.transform.position;
        }
        if(markTracker == 3)
        {
            theMarker.transform.position = point04.transform.position;
        }
        if(markTracker == 4)
        {
            theMarker.transform.position = point05.transform.position;
        }
        if(markTracker == 5)
        {
            theMarker.transform.position = point06.transform.position;
        }
        if(markTracker == 6)
        {
            theMarker.transform.position = point07.transform.position;
        }
        if(markTracker == 7)
        {
            theMarker.transform.position = point08.transform.position;
        }
        if(markTracker == 8)
        {
            theMarker.transform.position = point09.transform.position;
        }
        if(markTracker == 9)
        {
            theMarker.transform.position = point10.transform.position;
        }
        if(markTracker == 10)
        {
            theMarker.transform.position = point11.transform.position;
        }
        if(markTracker == 11)
        {
            theMarker.transform.position = point12.transform.position;
        }
        if(markTracker == 12)
        {
            theMarker.transform.position = point13.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "CPUcar")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            markTracker += 1;
            if(markTracker == 13)
            {
                markTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
