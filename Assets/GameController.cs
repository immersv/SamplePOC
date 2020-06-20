using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject videoPanel;
    // Start is called before the first frame update
   public void PlayAudio(string name)
    {
        Destroy(ThreeDModelManager.instance.tempModel);
        videoPanel.SetActive(false);
        AudioManager.instance.ClickOnPlaySound(name);
    }
    public void PlayVideo(string name)
    {
        Destroy(ThreeDModelManager.instance.tempModel);
        AudioManager.instance.ClickOnStopSound();
        videoPanel.SetActive(true);
        VideoManager.instance.ClickonPlayVideo(name);
      
    }
    public void PlayModel(string name)
    {
        ThreeDModelManager.instance.OnclickModel(name);
        AudioManager.instance.ClickOnStopSound();
        videoPanel.SetActive(false);

    }

}
