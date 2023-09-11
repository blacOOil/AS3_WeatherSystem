using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherDay : MonoBehaviour
{
    public static bool GameObjectDayLight = false;
    public GameObject DayLight;

    // Update is called once per frame
    void FixedUpdate() {
        if (GameObjectDayLight == true) {
            DayLightButtonTrue();
        } else {
            DayLightButtonFalse();
        }
    }

    public void DayLightButtonTrue() {
        DayLight.SetActive(true);
        GameObjectDayLight = true;
        Debug.Log("TimeSetDay : On");
    }

    public void DayLightButtonFalse() {
        DayLight.SetActive(false);
        GameObjectDayLight = false;
        Debug.Log("TimeSetDay : Off");
    }
}
