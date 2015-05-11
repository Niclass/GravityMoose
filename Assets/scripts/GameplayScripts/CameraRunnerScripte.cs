using UnityEngine;
using System.Collections;

public class CameraRunnerScripte : MonoBehaviour {

	public float speed;

	
	void Update () 
	{
        // Kamerans hanstighet
		this.transform.position = new Vector3 (transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);

	}
}
