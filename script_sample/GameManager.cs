ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject youWinText;
    public GameObject youLoseText;
    public AudioClip winAudioClip;
    public AudioClip loseAudioClip;
    public AudioSource audioSource;
    //public int sceneIndex;

    public float resetDelay;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);//no two game manager
        }
    }


    public void Win()
    {
        if (youLoseText.active != true)
        {
            if (youWinText.active != true)
            {
                audioSource.clip = winAudioClip;
                audioSource.loop = false;
                audioSource.Play();
                youWinText.SetActive(true);

                Invoke("NextScene", winAudioClip.length);

            }

            //display win message
            
            // slow down time ofor dramatic effect
            //Time.timeScale = .2f;
            //reset game
            //Invoke("Reset", resetDelay);
            
        }
        
    }

    public void NextScene()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        if(current == SceneManager.sceneCountInBuildSettings-1)
        {
            SceneManager.LoadScene(0);

        }
        else
        {
            SceneManager.LoadScene(current + 1);
        }

    }

    public void Lose()
    {
        if(youWinText.active != true)
        {
            if(youLoseText.active != true)
            {
                audioSource.clip = loseAudioClip;
                audioSource.loop = false;
                audioSource.Play();
            }
           
            //display win message
            youLoseText.SetActive(true);
            // slow down time ofor dramatic effect
            Time.timeScale = .2f;
            //reset game
            Invoke("Reset", resetDelay);
        }
        

    }

    public void Reset()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel(Application.loadedLevel);
    }
}
