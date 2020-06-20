using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ThreeDModelManager : MonoBehaviour
{
    public ThreeDModel[] threeDModels;
    public static ThreeDModelManager instance;
    public GameObject tempModel;
   

    void Awake()
    {
        instance = this;
    }
    public void OnclickModel(string modelname)
    {
            
            
            ThreeDModel t = Array.Find(threeDModels, threeDModels => threeDModels.threeDModelName == modelname);
            if (t == null)
            {
                Debug.Log("Error Model:" + modelname + " not found");

            }
            else
            {
                GameObject inst = Instantiate(Resources.Load("model", typeof(GameObject))) as GameObject;
                tempModel = inst;
                if (inst.activeInHierarchy == false)
                {
                    Destroy(inst);
                }
            }
        
        
    }
}
