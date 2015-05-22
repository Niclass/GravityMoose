using UnityEngine;
using System.Collections;

public class CameraRunnerScripte : MonoBehaviour {

	public float speed;
	PausMenu pause;

	
	void Update () 
	{
			// Kamerans position och hanstighet
			this.transform.position = new Vector3 (transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);
	}
}
