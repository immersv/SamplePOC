using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;
    public GameObject videoPanel, audioPanel,modelPanel;
    public static AudioManager instance;
    void Awake()
    {
       
        foreach(Sounds s in sounds)
        {
           s.source= gameObject.AddComponent<AudioSource>();
            s.source.clip = s.audioClip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
        
    }
   
    public void ClickOnPlaySound(string name)
    {
        videoPanel.SetActive(false);
        modelPanel.SetActive(false);
        audioPanel.SetActive(true);
        if (instance == null)
        {
            instance = this;
            Sounds s = Array.Find(sounds, sounds => sounds.audioclipName == name);
            if (s == null)
            {
                Debug.Log("Error Sound:" + name + " not found");
                return;
            }
            s.source.Play();
        }
       
       
    }
}
