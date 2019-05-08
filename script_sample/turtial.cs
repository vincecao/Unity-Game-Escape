ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turtial : MonoBehaviour
{
    public GameObject down;
    public GameObject left;
    public GameObject right;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        down.SetActive(true);
        left.SetActive(true);
        right.SetActive(true);
    }
}
