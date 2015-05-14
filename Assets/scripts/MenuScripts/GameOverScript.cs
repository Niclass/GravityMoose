using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	void Start () 
	{
        //laddar in poängen spelaren fick innan game over
		score = PlayerPrefs.GetInt ("Score");
	}
	void OnGUI()
	{
        //Ritar ut poäng
		GUI.Label (new Rect (Screen.width / 2 - 40, 200, 80, 30), "Score: " + score);
	}
	

}
