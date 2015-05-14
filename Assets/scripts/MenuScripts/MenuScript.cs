using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour 
{
    public Slider musicSlider;
    public Slider SFSlider;

    void Awake()
    {
        if (musicSlider)
        {
            GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("CurrentMusicVolume");
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
    }

    public void SFVolume(float SFVolume)
    {
        GetComponent<AudioSource>().volume = SFVolume;
        PlayerPrefs.SetFloat("CurrentSFVolume", GetComponent<AudioSource>().volume);
    }
	
}
