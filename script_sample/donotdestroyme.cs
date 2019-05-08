ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donotdestroyme : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
