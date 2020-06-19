
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.Video;
using System;

public class VideoManager : MonoBehaviour
{
    public Videos[] videos;
    public RawImage rawImage;
    public static VideoManager instance;
    public GameObject videoPanel,audioPanel,modelPanel;

    // Start is called before the first frame update
    void Awake()
    {

        foreach (Videos v in videos)
        {
           v.videoSource=gameObject.AddComponent<VideoPlayer>();
            v.source = gameObject.AddComponent<AudioSource>();           
            v.videoSource.playOnAwake = v.playOnAwake;
            v.videoSource.waitForFirstFrame = v.waitForFirstFrame;
            v.videoSource.source = VideoSource.VideoClip;
            v.videoSource.clip = v.videoClip;
            v.videoSource.audioOutputMode = VideoAudioOutputMode.AudioSource;
            v.videoSource.SetTargetAudioSource(0, v.source);
            
        }
    }
     public void Start()
     {
        
        
    }
    public void ClickonPlayVideo(String name)
    {
        audioPanel.SetActive(false);        
        modelPanel.SetActive(false);
        videoPanel.SetActive(true);
        StartCoroutine(PlayVideo(name));
       
    }
    IEnumerator PlayVideo(string name)
    {
        if (instance == null)
        {
            instance = this;
            Videos v = Array.Find(videos, videos => videos.videoClipName == name);
            if (v == null)
            {
                Debug.Log("Error Video:" + name + " not found");
                              
            }
            else
            {
                videos[0].videoSource.Prepare();
                WaitForSeconds waitForSeconds = new WaitForSeconds(1);
                while (!videos[0].videoSource.isPrepared)
                {
                    yield return waitForSeconds;
                    break;
                }
                rawImage.texture = videos[0].videoSource.texture;
                videos[0].videoSource.Play();
            }
            
        }
        else
        {
           // videos[0].videoSource.Stop();
        }
    }
}
