using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuMusicVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetVolume(float sliderValue)
    {
        mixer.SetFloat("MenuMusicVolume", Mathf.Log10(sliderValue) * 20);
    }
    
}
