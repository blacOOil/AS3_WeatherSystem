using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAmountSet : MonoBehaviour
{
    public GameObject Star1, Star2;
    // Start is called before the first frame update
    void Start()
    {
        Star1.SetActive(false);
        Star2.SetActive(false);
    }
    public void OnSliderChanged(float value)
    {
        if (value > 0.4)
        {
            Star1.SetActive(true);
            if (value == 1)
            {
                Star2.SetActive(true);
            }
        }
        else
        {
            Star1.SetActive(false);
            Star2.SetActive(false);
        }

    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
