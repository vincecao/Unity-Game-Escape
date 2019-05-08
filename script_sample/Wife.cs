ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wife : MonoBehaviour
{
    float speed = 5.0f;
    bool enter = false;
    public Transform target;
    public GameObject man;

    // Start is called before the first frame update
    void Start()
    {
        enter = false;
        transform.position = new Vector3(Random.Range(30f, 40f), 2.7f, Random.Range(50f, 80f));
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(target);
        transform.position += transform.forward * speed * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == man && enter == false)
        {
            speed += 2.0f;
            enter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == man && enter == true)
        {
            enter = false;
        }
    }
}
