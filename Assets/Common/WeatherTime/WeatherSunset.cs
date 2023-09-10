using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherSunset : MonoBehaviour
{
    public static bool GameObjectSunsetLight = false;
    public GameObject SunsetLight;

    // Update is called once per frame
    void Update() {
        if (GameObjectSunsetLight == true) {
            SunsetLightButtonTrue();
        } else {
            SunsetLightButtonFalse();
        }
    }

    public void SunsetLightButtonTrue() {
        SunsetLight.SetActive(true);
        GameObjectSunsetLight = true;
        Debug.Log("TimeSetSunset : On");
    }

    public void SunsetLightButtonFalse() {
        SunsetLight.SetActive(false);
        GameObjectSunsetLight = false;
        Debug.Log("TimeSetSunset : Off");
    }
}
