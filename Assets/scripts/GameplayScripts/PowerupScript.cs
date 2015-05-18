using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour
{
    public static int amount = 10;
    public AudioSource powerUpSoundEffect;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<moosecontroller>() == null)
            return;

        HudScript.IncreaseScore(amount);
        powerUpSoundEffect.Play();
        Destroy(gameObject);

    }
}
