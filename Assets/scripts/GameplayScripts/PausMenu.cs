using UnityEngine;
using System.Collections;

public class PausMenu : MonoBehaviour 
{
    public bool isPaused = false;
    public GameObject pauseMenuCanvas;
	
	void Update () 
    {
		pauseMenuCanvas.SetActive(false);
		Time.timeScale = 1f;

        //if(isPaused)
        //{
        //    pauseMenuCanvas.SetActive(true);
        //    Time.timeScale = 0f;
        //}

        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        //    isPaused = true;
        //}

        //if (isPaused = true && Input.GetKeyDown (KeyCode.Escape)) 
        //{
        //    isPaused = false;
        //}
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
