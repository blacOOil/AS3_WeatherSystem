using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowfall : MonoBehaviour {
    //public GameObject snowflakePrefab;
    public GameObject snowflakeShapePrefab;

    void Start() {
        //InvokeRepeating("SpawnSnowflake", 0f, 0.5f);
        InvokeRepeating("SpawnSnowflakeShape", 0f, 0.5f);
    }

    void SpawnSnowflakeShape() {
        float xPos = Random.Range(-9f, 9f);
        Vector3 spawnPos = new Vector3(xPos, 7f, 0f);

        GameObject snowflake = Instantiate(snowflakeShapePrefab, spawnPos, Quaternion.identity);
        snowflake.transform.parent = transform;
    }

    // public static bool GameObjectSnow = false;
    // public GameObject snowflakeShapePrefab;

    // void Update() {
    //     if (GameObjectSnow == true) {
    //         SnowButtonTrue();
    //     } else {
    //         SnowButtonFalse();
    //     }
    // }

    // // void SpawnSnowflake()
    // // {
    // //     float xPos = Random.Range(-9f, 9f);
    // //     Vector3 spawnPos = new Vector3(xPos, 7f, 0f);

    // //     GameObject snowflake = Instantiate(snowflakePrefab, spawnPos, Quaternion.identity);
    // //     snowflake.transform.parent = transform;
    // // }
    // public void SnowButtonTrue() {
    //     InvokeRepeating("SpawnSnowflakeShape", 0f, 0.5f);
    //     snowflakeShapePrefab.SetActive(true);
    //     GameObjectSnow = true;
    //     Debug.Log("WeatherSetSnow : On");
    // }

    // public void SnowButtonFalse() {
    //     InvokeRepeating("SpawnSnowflakeShape", 0f, 0.5f);
    //     snowflakeShapePrefab.SetActive(false);
    //     GameObjectSnow = false;
    //     Debug.Log("WeatherSetSnow : Off");
    // }

    // void SpawnSnowflakeShape() {
    //     float xPos = Random.Range(-9f, 9f);
    //     Vector3 spawnPos = new Vector3(xPos, 7f, 0f);

    //     GameObject snowflake = Instantiate(snowflakeShapePrefab, spawnPos, Quaternion.identity);
    //     snowflake.transform.parent = transform;
    // }
}
