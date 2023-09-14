using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController2 : MonoBehaviour
{
    public static bool GameObjectRainSet = false;
    public GameObject RainGroup;
    public GameObject Rain1;
    public GameObject Rain2;
  

     void Start()
    {
        RainGroup.SetActive(false);
        Rain1.SetActive(false);
        Rain2.SetActive(false);
    }
    void Update()
    {
        if(GameObjectRainSet == true)
        {
            RainButtonTrue();
        }
        else
        {
            RainButtonFalse();
        }

    }
    
    public void RainButtonTrue()
    {
        
        RainGroup.SetActive(true);
        GameObjectRainSet = true;
    }
    public void RainButtonFalse()
    {
        
        RainGroup.SetActive(false);
        GameObjectRainSet = false;

    }
    public void OnSliderChanged(float value)
    {
       if (value > 0.4)
        {
            Rain1.SetActive(true);
            if(value == 1)
            {
                Rain2.SetActive(true);
            }
        }
        else
        {
            Rain1.SetActive(false);
            Rain2.SetActive(false);
        }
    }
    
}
