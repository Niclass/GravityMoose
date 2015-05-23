using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{// gör så att när spelaren där så laddas game over scenen
		if (other.tag == "Player") 
		{
            Application.LoadLevel("GameOverScene");
			return;
		}


        //if (other.gameObject.transform) 
        //{// destroyern förstör allt annat som går igenom
        //    Destroy(other.gameObject);
        //} 

        



	}
}
