using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	HudScript hud;
	public AudioSource powerUpSound;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Power Up")) 
		{
			hud = GameObject.Find("Character").GetComponent<HudScript>();
			hud.IncreaseScore(10);
			powerUpSound.Play();
			Destroy(other.gameObject);
		}
	}
}
