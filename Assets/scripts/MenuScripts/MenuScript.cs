using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour 
{
    public Slider musicSlider;

    void Awake()
    {
        if (musicSlider)
        {
            GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("CurrentMusicVolume");
            GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFVolume");
            musicSlider.value = GetComponent<AudioSource>().volume;
            
        }
    }
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    public void MusicVolume(float musicVolume)
    {
        GetComponent<AudioSource>().volume = musicVolume;
        PlayerPrefs.SetFloat("CurrentMusicVolume", GetComponent<AudioSource>().volume);
        PlayerPrefs.SetFloat("SFVolume", GetComponent<AudioSource>().volume);
    }

    public void Quit()
    {
        Application.Quit();
    }
	
}
