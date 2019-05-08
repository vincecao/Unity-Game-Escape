ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finish : MonoBehaviour
{
    AudioSource audios;
    public Button btn;

    void Start()
    {
        audios = GetComponent<AudioSource>();
        Invoke("NextScene", audios.clip.length);
        btn.onClick.AddListener(NextScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextScene()
    {
        SceneManager.LoadScene(0);

    }

}
