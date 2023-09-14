using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raining : MonoBehaviour
{
    public static bool RainGameObjectSet = false;
    public GameObject RainingPrefab;
    // Start is called before the first frame update
    void Update()
    {
        if(RainGameObjectSet == true)
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
        RainingPrefab.SetActive(true);
        RainGameObjectSet = true;
        Debug.Log("WeatherRainSet : On");
    }
    public void RainButtonFalse()
    {
        InvokeRepeating("SpawnRainShape", 0f, 0.5f);
        RainingPrefab.SetActive(false);
        RainGameObjectSet = false;
        Debug.Log("WeatherRainSet : Off");
    }
    
    

}
