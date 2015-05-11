using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	void OnGUI()
	{

		
		
		Rect startButtonRect = new Rect(Screen.width / 2 - 40, 250, 80, 30);

		Rect highScoreButtonRect = new Rect (Screen.width / 2 - 40, 300, 100, 30);

		Rect optionButtonRect = new Rect(Screen.width / 2 - 40, 350, 80, 30);

		Rect quitButtonRect = new Rect(Screen.width / 2 - 40, 400, 80, 30);


		
		
		if(GUI.Button(startButtonRect,"Start!"))
		{
			//1 är gamplayscenen
			Application.LoadLevel(1);
		}

		if(GUI.Button(highScoreButtonRect,"High Score"))
		{
			
			Debug.Log("Det finns ingen just nu :(:(");
		}

		if(GUI.Button(optionButtonRect,"options"))
		{
			
			Application.LoadLevel(3);
		}

		if(GUI.Button(quitButtonRect,"Quit"))
		{

			Application.Quit();
		}
	}
}
