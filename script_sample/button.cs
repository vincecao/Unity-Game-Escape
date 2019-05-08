ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// To use this example, attach this script to an empty GameObject.
// Create three buttons (Create>UI>Button). Next, select your
// empty GameObject in the Hierarchy and click and drag each of your
// Buttons from the Hierarchy to the Your First Button, Your Second Button
// and Your Third Button fields in the Inspector.
// Click each Button in Play Mode to output their message to the console.
// Note that click means press down and then release.

public class button : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button down, left, right, up;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        up.onClick.AddListener(cTaskOnClick);
        left.onClick.AddListener(delegate { cWithParameters("Hello"); });
        right.onClick.AddListener(() => cButtonClicked(42));
        down.onClick.AddListener(cTaskOnClick);
    }

    void cTaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }

    void cWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void cButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }
}
