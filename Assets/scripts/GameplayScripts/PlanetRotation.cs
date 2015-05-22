using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {

	
	void Update () 
    {
        transform.Rotate(new Vector3(0, 0, 175 / Mathf.DeltaAngle(1,180) * Time.deltaTime));
	}
}
