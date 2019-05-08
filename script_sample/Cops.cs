ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cops : MonoBehaviour
{
    public float speed;
    bool enter = false;

    void Start()
    { 
        enter = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CopTriggerBack" && enter == false)
        {
            transform.Rotate(0, 180, 0);//back
            Debug.Log("enter back trigger");
            enter = true;
        }
        if(other.gameObject.tag == "player")
        {
            Debug.Log("you met with cops");
            GameManager.instance.Lose();
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "CopTriggerBack")
        {
            Debug.Log("leave back trigger");
            enter = false;
        }
    }
}
