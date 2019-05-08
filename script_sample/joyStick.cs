ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joyStick : MonoBehaviour
{

    protected Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(
            joystick.Horizontal * 5f,
            rigidbody.velocity.y,
            joystick.Vertical * 5f
           );
    }
}
