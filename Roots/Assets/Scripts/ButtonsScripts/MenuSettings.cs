using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    //public  GameObject SoundsManager;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("mixerVolume", volume);
    }

    public void SetSounds(bool IsTicked)
    {
      //  SoundsManager.active=IsTicked;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
