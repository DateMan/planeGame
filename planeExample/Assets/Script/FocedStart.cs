﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FocedStart : MonoBehaviour
{
    //[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    static void FirstLoad()
    {
        if (SceneManager.GetActiveScene().name.CompareTo("StartMenu") != 0)
        {
            SceneManager.LoadScene("StartMenu");
        }
    }



}
