using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    Text text;
    
    void Start()
    {
        //laddar in poängen spelaren fick innan game over
        text = GetComponent<Text>();

        score = PlayerPrefs.GetInt("HighScore");
        score = PlayerPrefs.GetInt("Score");
    }

    void OnGUI()
    {
        //Ritar ut poäng
        GUI.Label(new Rect(Screen.width / 2 -80, Screen.height / 2 + 50, 280, 300), "<color=green><size=40>Score: </size></color>" + score);
        //GUI.Label(new Rect(Screen.width / 2 - 40, 400, 280, 300), "<color=green><size=40>High Score: </size></color>" + score);
    }

    void Text()
    {
        text.text = "" + ((int)highScore);
    }
}
