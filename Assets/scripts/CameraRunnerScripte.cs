using UnityEngine;
using System.Collections;

public class CameraRunnerScripte : MonoBehaviour {

	public float speed;

	
	// Update is called once per frame
	void Update () 
	{
		this.transform.position = new Vector3 (transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);

	}
}
