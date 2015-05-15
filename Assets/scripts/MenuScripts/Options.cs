using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Options : MonoBehaviour 
{
    public Slider musicSlider;
    public Slider sFSlider;

    void Awake()
    {
        if (musicSlider)
        {
            GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("CurrentMusicVolume");
            musicSlider.value = GetComponent<AudioSource>().volume;
        }

        if (sFSlider)
        {
            GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("CurrentMusicVolume");
            sFSlider.value = GetComponent<AudioSource>().volume;
        }
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
