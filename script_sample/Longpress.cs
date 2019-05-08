ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Longpress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    private bool isDown = false;
    public int btnIndex;

    void Start()
    {

    }
    void Update()
    {
        if (isDown)
        {

            Debug.Log("Long Press");

            GameObject go = GameObject.Find("Run");

            Run run = (Run)go.GetComponent(typeof(Run));
            var speed = run.speed;
            run.buttonAction(btnIndex, speed);

        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {

        isDown = true;

    }
    public void OnPointerUp(PointerEventData eventData)
    {

        isDown = false;

    }
    public void OnPointerExit(PointerEventData eventData)
    {

        isDown = false;

    }
}
