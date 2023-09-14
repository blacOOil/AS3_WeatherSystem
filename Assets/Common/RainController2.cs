using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController2 : MonoBehaviour
{
    public static bool GameObjectRainSet = false;
    public GameObject RainGroup;

     void Start()
    {
        RainGroup.SetActive(false);  
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
        InvokeRepeating("SpawnRainShape",0f,0.5f);
        RainGroup.SetActive(true);
        GameObjectRainSet = true;
    }
    public void RainButtonFalse()
    {
        InvokeRepeating("SpawnRainShape",0f,0.5f);
        RainGroup.SetActive(false);
        GameObjectRainSet = false;

    }
}
