﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sounds
{
    public string clipName;
    public AudioClip clip;
    [Range(0f,1f)]
    public float volume;
    [Range(0.1f,3.0f)]
    public float pitch;
    [HideInInspector]
    public AudioSource source;
}
