ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{
    Rigidbody rb;
    public ProgressBar Pb;
    bool isEnter;
    //public int localSpeed;
    public int speed;
    int reward;
    float punish;
    //public bool GasDown;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        Pb.BarValue = 100;

    }


    private void Update()
    {
        GameObject go = GameObject.Find("Gas");
        Gas gas = (Gas)go.GetComponent(typeof(Gas));
        if (gas.isDown())
        {
            speed = 10;
            Pb.BarValue -= 0.15f + punish;
        }
        else
        {
            speed = 5;
        }


        if ((Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.Space)) && isGrounded())
        {
            Debug.Log("Pressed Space");
            rb.AddForce(Vector3.up * 700, ForceMode.Impulse);
        }

        if (Input.GetKey("s")) //2
        {
            Debug.Log("Pressed S");
            buttonAction(2, speed);
        }

        if (Input.GetKey("w")) //0
        {
            Debug.Log("Pressed W");
            buttonAction(0, speed);
        }


        if (Input.GetKey("a")) //3
        {
            Debug.Log("Pressed A");
            buttonAction(3, speed);
        }

        if (Input.GetKey("d")) //1
        {
            buttonAction(1, speed);
        }

    }

    bool isGrounded()
    {
        if (rb.position.y <= 0)
        {
            return true;
        }
        return false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CountyRoad")
        {
            reward = 0;
            punish = 0.03f;
        }
        else if (collision.gameObject.tag == "CityRoad")
        {
            reward = 2;
            punish = 0.04f;
        }
        else if (collision.gameObject.tag == "HighWay")
        {
            reward = 4;
            punish = 0.05f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GasStation")
        {
            Pb.BarValue = 100f;
            isEnter = true;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GasStation")
        {
            isEnter = false;
        }

    }

    void onRoad(int speed)
    {
        rb.MovePosition(transform.position + transform.forward * (speed + reward) * Time.deltaTime);
        if (!isEnter)
        {
            Pb.BarValue -= 0.05f + punish;
        }

        if (Pb.BarValue == 0.00f)
        {
            Debug.Log("Gas run out");
            GameManager.instance.Lose();
        }
        
    }

     public void buttonAction(int index, int speed)
    {
        if (index == 0) //up
        {
            transform.forward = new Vector3(0f, 0f, 1f);
            onRoad(speed);
        }
        if (index == 1) //right
        {
            transform.forward = new Vector3(1f, 0f, 0f);
            onRoad(speed);
        }
        if (index == 2) //down
        {
            transform.forward = new Vector3(0f, 0f, -1f);
            onRoad(speed);
        }
        if (index == 3) //left
        {
            transform.forward = new Vector3(-1f, 0f, 0f);
            onRoad(speed);
        }
    }
}
