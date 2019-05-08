ï»¿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_scene_on_click : MonoBehaviour
{
    public void load_by_index(int scene_index)
    {
        SceneManager.LoadScene(scene_index);
    }
}
