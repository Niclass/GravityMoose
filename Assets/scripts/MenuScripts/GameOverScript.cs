using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;

    public Text ScoreText;
    public Text highScoreText; 
    
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        score = PlayerPrefs.GetInt("Score");

        if(score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.SetInt("Score", score);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetInt("Score", score);
        }
        
        ScoreText.text = "Your score: " + score;
        highScoreText.text = "High Score: " + (score > highScore ? score : highScore);
        
    }

    
}
