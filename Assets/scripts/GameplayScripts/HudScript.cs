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
        text.text = "" + ((int)playerScore );
	}

	public static void IncreaseScore(float amount)
	{
		playerScore += amount;
	}

	public void OnDisable()
	{
        if (playerScore > PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Score", (int)(playerScore));
        }
        //else
        //{
        //    PlayerPrefs.SetInt("Score", (int)(playerScore));
        //}
	}

	
}
