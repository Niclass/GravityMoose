﻿using UnityEngine;
using System.Collections;

public class PausMenu : MonoBehaviour 
{
    public bool isPaused = false;
    public GameObject pauseMenuCanvas;
	
	void Update () 
    {
		if(isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
	}

    public void Resume()
    {
        isPaused = false;
    }

    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
