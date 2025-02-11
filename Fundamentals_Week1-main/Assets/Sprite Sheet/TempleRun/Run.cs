using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Run : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator TempRun;

    private void Start()
    {
        TempRun = GetComponent<Animator>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        // string name
        // bool value = T/F
        TempRun.SetBool("isidle",true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TempRun.SetBool("isidle", false);
    }
}
