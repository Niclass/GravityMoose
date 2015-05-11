using UnityEngine;
using System.Collections;

public class HudScript : MonoBehaviour {

	float playerScore = 0;


	void Update () 
	{
        // uppdaterar poäng
		playerScore += Time.deltaTime;
	}

	public void IncreaseScore(int amount)
	{
        // plussar på poäng
		playerScore += amount;
	}

	void OnDisable()
	{
        // sparar poängen till game over scenen
		PlayerPrefs.SetInt ("Score", (int)(playerScore * 10));
	}

	void OnGUI()
	{
        // enkel text som visar poängen
		GUI.Label(new Rect(10,10,100,30), "Score: " + (int) (playerScore * 10));
	}
}
