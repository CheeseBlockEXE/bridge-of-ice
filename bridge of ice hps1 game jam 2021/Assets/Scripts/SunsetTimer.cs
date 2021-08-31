using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunsetTimer : MonoBehaviour
{

    Light worldLight;

    Color dayLight;
    Color sunset;

    float baseIntensity = 1.5f;

    void Start()
    {
        worldLight = GetComponent<Light>();

        dayLight = new Vector4(0.8284087f, 0.9150651f, 0.9811321f);
        sunset = new Vector4(0.9716981f, 0.8430023f, 0.7562745f);

        worldLight.intensity = baseIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        float countPercent = TheTimer.theTimer.counter();
        
       
        worldLight.intensity = baseIntensity * countPercent;

        worldLight.color = Color.Lerp(sunset, dayLight, countPercent);

    }
}
