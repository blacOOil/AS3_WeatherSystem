using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherNight : MonoBehaviour
{
    public static bool GameObjectNightLight = false;
    public GameObject NightLight;

    // Update is called once per frame
    void Update() {
        if (GameObjectNightLight == true) {
            NightLightButtonTrue();
        } else {
            NightLightButtonFalse();
        }
    }

    public void NightLightButtonTrue() {
        NightLight.SetActive(true);
        GameObjectNightLight = true;
        Debug.Log("TimeSetNight : On");
    }

    public void NightLightButtonFalse() {
        NightLight.SetActive(false);
        GameObjectNightLight = false;
        Debug.Log("TimeSetNight : Off");
    }
}
