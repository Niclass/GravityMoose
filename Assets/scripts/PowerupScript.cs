using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	HudScript hud;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Power Up")) 
		{
			hud = GameObject.Find("Character").GetComponent<HudScript>();
			hud.IncreaseScore(100);
			Destroy(other.gameObject);
		}
	}
}
