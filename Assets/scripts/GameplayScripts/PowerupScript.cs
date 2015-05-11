using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	HudScript hud;
	public AudioSource powerUpSound;

    
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Power Up")) 
		{
            // om ett objekt har taggen power up så ger den extra poäng, ljud spelas upp och den förstörs
			hud = GameObject.Find("Character").GetComponent<HudScript>();
			hud.IncreaseScore(10);
			powerUpSound.Play();
			Destroy(other.gameObject);
		}
	}
}
