using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowController : MonoBehaviour {
    public static bool GameObjectSnowSet = false;
    public GameObject SnowGroup;
    void Update() {
        if (GameObjectSnowSet == true) {
            SnowButtonTrue();
        } else {
            SnowButtonFalse();
        }
    }

    public void SnowButtonTrue() {
        InvokeRepeating("SpawnSnowflakeShape", 0f, 0.5f);
        SnowGroup.SetActive(true);
        GameObjectSnowSet = true;
        Debug.Log("WeatherSetSnow : On");
    }

    public void SnowButtonFalse() {
        InvokeRepeating("SpawnSnowflakeShape", 0f, 0.5f);
        SnowGroup.SetActive(false);
        GameObjectSnowSet = false;
        Debug.Log("WeatherSetSnow : Off");
    }
}
