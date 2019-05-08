ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject man;
    public GameObject wife;
    public GameObject wife_main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == man)
        {
            Debug.Log("Man reached the goal");
            GameManager.instance.Win();

        }
        /*else if(other.gameObject == wife_main)
        {
            Debug.Log("Wife reached the goal");
            GameManager.instance.Lose();
        }*/
    }
}
