using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class Video : MonoBehaviour 
{
    public MovieTexture intro;
	void Start () 
    {
        GetComponent<Renderer>().material.mainTexture = intro as MovieTexture;
        GetComponent<AudioSource>().clip = intro.audioClip;
        intro.Play();
        GetComponent<AudioSource>().Play();
	}
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            intro.Stop();
            Application.LoadLevel("Menu");
        }
        if (!intro.isPlaying) Application.LoadLevel("Menu");   

    }
	
}
