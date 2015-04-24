using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	void Start () 
	{
		score = PlayerPrefs.GetInt ("Score") * 10;
	}
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 350, 60, 30), "Restart")) 
		{
			Application.LoadLevel(1);
		}
	}
	

}
