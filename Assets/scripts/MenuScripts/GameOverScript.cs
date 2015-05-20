using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    int score = 0;
    
    void Start()
    {
        //laddar in poängen spelaren fick innan game over
        score = PlayerPrefs.GetInt("Score");
    }

    void OnGUI()
    {
        //Ritar ut poäng
        GUI.Label(new Rect(Screen.width / 2 - 40, 200, 280, 300), "<color=green><size=40>Score: </size></color>" + score);
    }
}
