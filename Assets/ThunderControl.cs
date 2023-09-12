using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThunderControl : MonoBehaviour
{
    // Reference to the RainControl script
    public RainControl rainControl;

    private AudioSource thunderSound;

    private void Start()
    {
        // Get the AudioSource for thunder sound
        thunderSound = GetComponent<AudioSource>();

        // Add a listener to the rain control's slider
        rainControl.rainSlider.onValueChanged.AddListener(AdjustThunderSound);

        // Adjust the thunder sound initially
        AdjustThunderSound(rainControl.rainSlider.value);
    }

    public void AdjustThunderSound(float volume)
    {
        // Calculate the chance of playing the thunder sound based on the volume
        float chance = Mathf.Clamp01(volume / 50f); // Adjust this as needed

        // Check if the thunder sound should play
        bool shouldPlayThunder = Random.value <= chance;

        // Play or stop the thunder sound based on the chance
        if (shouldPlayThunder)
        {
            if (!thunderSound.isPlaying)
            {
                thunderSound.Play();
            }
        }
        else
        {
            thunderSound.Pause();
        }
    }
}