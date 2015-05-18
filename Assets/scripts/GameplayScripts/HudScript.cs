using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HudScript : MonoBehaviour {

	PausMenu pause;

	public static float playerScore;

    Text text;


    public void Start()
    {
        text = GetComponent<Text>();
        playerScore = 0f;
    }
	public void Update () 
	{   
        playerScore += Time.deltaTime;
        text.text = "" + (playerScore );
	}

	public static void IncreaseScore(float amount)
	{
		playerScore += amount;
	}

	public void OnDisable()
	{
		PlayerPrefs.SetInt ("Score", (int)(playerScore));
	}

	
}
