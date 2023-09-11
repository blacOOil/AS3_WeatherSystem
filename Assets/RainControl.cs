using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RainControl : MonoBehaviour
{
    public ParticleSystem rainParticleSystem;
    public Slider rainSlider;
    public AudioSource rainSound; // เสียงฝน
    public AudioSource thunderSound; // เสียงฟ้าร้อง

    private ParticleSystem.EmissionModule emissionModule;

    private void Start()
    {
        // Get the Particle System's Emission module
        emissionModule = rainParticleSystem.emission;

        // Add a listener to the slider's value change event
        rainSlider.onValueChanged.AddListener(AdjustRainIntensity);

        // Set the initial sound volume
        AdjustSoundVolume(emissionModule.rateOverTime.constant);
    }

    public void AdjustRainIntensity(float intensity)
    {
        // Ensure that intensity is within the desired range (0 to 1)
        intensity = Mathf.Clamp01(intensity);

        // Map the intensity value to the desired range (0 to 50)
        float mappedIntensity = intensity * 50f;

        // Update the Rate over Time based on the mapped intensity
        emissionModule.rateOverTime = mappedIntensity;

        // Adjust the sound volume
        AdjustSoundVolume(mappedIntensity);
    }

    private void AdjustSoundVolume(float intensity)
    {
        // Map the intensity value to the desired sound volume range (0 to 1)
        float soundVolume = intensity / 50f;

        // Set the sound volume for rain
        rainSound.volume = soundVolume;

        // Pause or play the rain sound based on the sound volume
        if (soundVolume > 0)
        {
            if (!rainSound.isPlaying)
            {
                rainSound.Play();
            }
        }
        else
        {
            rainSound.Pause();
        }

        // Calculate the chance of playing the thunder sound based on the sound volume
        float thunderChance = Mathf.Clamp01(soundVolume); // Adjust this as needed

        // Check if the thunder sound should play
        bool shouldPlayThunder = Random.value <= thunderChance;

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