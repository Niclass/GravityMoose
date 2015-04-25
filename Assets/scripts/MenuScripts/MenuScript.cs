using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	void OnGUI()
	{

		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect startButtonRect = new Rect(Screen.width / 2 - 40, 250, 80, 30);

		Rect highScoreButtonRect = new Rect (Screen.width / 2 - 40, 300, 100, 30);

		Rect optionButtonRect = new Rect(Screen.width / 2 - 40, 350, 80, 30);

		Rect quitButtonRect = new Rect(Screen.width / 2 - 40, 400, 80, 30);


		
		// Draw a button to start the game
		if(GUI.Button(startButtonRect,"Start!"))
		{
			//1 är gamplayscenen
			Application.LoadLevel(1);
		}

		if(GUI.Button(highScoreButtonRect,"High Score"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Debug.Log("Det finns ingen just nu :(:(");
		}

		if(GUI.Button(optionButtonRect,"options"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel(3);
		}

		if(GUI.Button(quitButtonRect,"Quit"))
		{

			Application.Quit();
		}
	}
}
