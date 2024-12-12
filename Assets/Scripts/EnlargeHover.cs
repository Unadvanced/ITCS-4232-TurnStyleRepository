using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnlargeHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 cachedScale;
    public GameObject carObj;
    public GameObject carStatObj;
    void Start()
    {
        cachedScale = carObj.transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        carObj.transform.localScale = new Vector3(52f, 52f, 52f);
        carStatObj.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        carObj.transform.localScale = cachedScale;
        carStatObj.SetActive(false);
    }
}
