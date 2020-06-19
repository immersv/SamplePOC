using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[System.Serializable]
public class Videos
{
    public string videoClipName;
    public VideoClip videoClip;
    public bool playOnAwake;
    public bool waitForFirstFrame;
    [HideInInspector]
    public AudioSource source;
    [HideInInspector]
    public VideoPlayer videoSource;
}
