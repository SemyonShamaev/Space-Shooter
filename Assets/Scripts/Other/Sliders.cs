using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Sliders : MonoBehaviour
{
    [SerializeField]
    private Slider slid;
    [SerializeField]
    private AudioMixer masterMixer;
    
    private string key;
    private int minThresholdVolume = -80, maxThresholdVolume = 0;

    public void setSettings()
    {
        key = slid.name;
        if (PlayerPrefs.HasKey(key))
        { 
            if (key == "MusicSlider")
            {
                slid.value = PlayerPrefs.GetFloat(key);
                masterMixer.SetFloat("VolumeMusic", Mathf.Lerp(minThresholdVolume, maxThresholdVolume, slid.value));
            }
            else
            {
                slid.value = PlayerPrefs.GetFloat(key);
                masterMixer.SetFloat("VolumeEffects", Mathf.Lerp(minThresholdVolume, maxThresholdVolume, slid.value));
            }
        }
    }

    public void ChangeVolumeEffects()
    {
    	masterMixer.SetFloat("VolumeEffects", Mathf.Lerp(minThresholdVolume, maxThresholdVolume, slid.value));
        Save();
    }

    public void ChangeVolumeMusic()
    {
    	masterMixer.SetFloat("VolumeMusic",  Mathf.Lerp(minThresholdVolume, maxThresholdVolume, slid.value));
        Save();
    }

    private void Save()
    {
        PlayerPrefs.SetFloat(key, this.slid.value);
        PlayerPrefs.Save();
    }
}