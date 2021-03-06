﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;
   
    public static AudioManager instance;
    void Awake()
    {
        instance = this;
        foreach (Sounds s in sounds)
        {
           s.source= gameObject.AddComponent<AudioSource>();
            s.source.clip = s.audioClip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
        
    }
   
    public void ClickOnPlaySound(string name)
    {       
         
            Sounds s = Array.Find(sounds, sounds => sounds.audioclipName == name);
            if (s == null)
            {
                Debug.Log("Error Sound:" + name + " not found");
                return;
            }
            s.source.Play();
                 
    }
    public void ClickOnStopSound()
    {
        foreach(Sounds s in sounds)
        {
            s.source = gameObject.GetComponent<AudioSource>();
            s.source.Stop();
        }
    }
}
