using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	void Start () 
	{
		score = PlayerPrefs.GetInt ("Score");
	}
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 350, 60, 30), "Restart")) 
		{
			Application.LoadLevel(1);
		}

		if (GUI.Button (new Rect (Screen.width / 2 - 30, 400, 100, 30), "High Score")) 
		{
			Application.LoadLevel(0);
		}

		if (GUI.Button (new Rect (Screen.width / 2 - 30, 450, 60, 30), "Menu")) 
		{
			Application.LoadLevel(0);
		}
	}
	

}
