using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ThreeDModelManager : MonoBehaviour
{
    public ThreeDModel[] threeDModels;
    public static ThreeDModelManager instance;
    public GameObject videoPanel, audioPanel,modelPanel;

    void Awake()
    {

    }
    public void OnclickModel(string modelname)
    {
        audioPanel.SetActive(false);
        videoPanel.SetActive(false);
        modelPanel.SetActive(true);
        if (instance == null)
        {
            instance = this;
            ThreeDModel t = Array.Find(threeDModels, threeDModels => threeDModels.threeDModelName == modelname);
            if (t == null)
            {
                Debug.Log("Error Model:" + modelname + " not found");

            }
            else
            {
                GameObject inst = Instantiate(Resources.Load("model", typeof(GameObject))) as GameObject;

            }
        }
        
    }
}
