ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheriff : MonoBehaviour
{
    public Transform target;
    public float speed;
    public GameObject Char;
    bool enter = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.position += transform.forward * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, 3, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Char && enter == false)
        {
            speed += 2.0f;
            enter = true;
            GameManager.instance.Lose();
        }
    }
}
