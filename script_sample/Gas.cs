ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Gas : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    private bool down = false;

    public AudioClip MusicClip;
    public AudioSource MusicSource;

    public void OnPointerDown(PointerEventData eventData)
    {
        down = true;
        GameObject winText = GameObject.Find("Win Text");
        GameObject loseText = GameObject.Find("Lose Text");
        if(!winText && !loseText)
        {
            MusicSource.Play();
        }
    
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        down = false;
        //MusicSource.Stop();

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        down = false;
        MusicSource.Stop();
    }

    public bool isDown()
    {
        return down;
    }

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (down)
        //{

        //    Debug.Log("Gas Press");

        //    GameObject go = GameObject.Find("Run");

        //    Run run = (Run)go.GetComponent(typeof(Run));
        //    var speed = run.speed;
        //    run.buttonAction(btnIndex, speed);

        //}

        //if (down)
        //{
        //    MusicSource.Play();
        //}
        //else
        //{
        //    //MusicSource.Stop();

        //}
    }
}
