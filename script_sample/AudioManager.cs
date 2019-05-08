ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource music;
    public Slider musicVolume;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
            PlayerPrefs.SetFloat("musicVolume", 1);
        musicVolume.value = PlayerPrefs.GetFloat("MusicVolume");
        
    }

    // Update is called once per frame
    void Update()
    {
        music.volume = musicVolume.value;
        VolumePrefs();
    }

    public void VolumePrefs()
    {
        PlayerPrefs.SetFloat("MusicVolume", music.volume);
        //PlayerPrefs.SetFloat("MusicVolume", musicVolume.value);
    }

    public void SavePlayerPrefs()
    {
        PlayerPrefs.Save();  //Saves PlayerPrefs levels
    }
}
