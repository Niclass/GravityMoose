using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {


    public moosecontroller characterController;
 public float speedFactor = 1; 
 Vector3 velocity;
	
	
	void Update () 
    {
	    velocity.x = characterController.maxSpeed * speedFactor;
        transform.Translate(velocity * Time.deltaTime);
	}
}
