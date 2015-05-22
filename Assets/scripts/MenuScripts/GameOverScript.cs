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
        highScore = PlayerPrefs.GetInt("highScore");
        score = PlayerPrefs.GetInt("Score");

        if(score > highScore)
        {
            PlayerPrefs.SetInt("highScore", score);
            PlayerPrefs.Save();
        }
        ScoreText.text = "Your score: " + score;
        highScoreText.text = "High Score: " + (score > highScore ? score : highScore);
    }

    
}
