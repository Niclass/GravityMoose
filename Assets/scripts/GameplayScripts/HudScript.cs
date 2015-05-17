using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HudScript : MonoBehaviour {

	PausMenu pause;

	public static int playerScore;

    Text text;


    public void Start()
    {
        text = GetComponent<Text>();
        playerScore = 0;
    }
	public void Update () 
	{   
        playerScore += 1;
        text.text = "" + (playerScore);
	}

	public static void IncreaseScore(int amount)
	{
		playerScore += amount;
	}

	public void OnDisable()
	{
		PlayerPrefs.SetInt ("Score", (int)(playerScore * 10));
	}

	
}
