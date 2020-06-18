using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;
    
    void Awake()
    {
        foreach(Sounds s in sounds)
        {
           s.source= gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
        
    }
   
    public void ClickOnPlaySound(string name)
    {
        Sounds s=Array.Find(sounds, sounds => sounds.clipName == name);
        if(s==null)
        {
            Debug.Log("Error Sound:" + name + " not found");
            return;
        }
        s.source.Play();
    }
}
