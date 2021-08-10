using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunsetTimer : MonoBehaviour
{

    Light worldLight;

    Color dayLight;
    Color sunset;

    //total time of sunlight available
    public float timer;

    
    // Start is called before the first frame update
    void Start()
    {
        worldLight = GetComponent<Light>();

        dayLight = new Vector4(0.8284087f, 0.9150651f, 0.9811321f);
        sunset = new Vector4(0.9716981f, 0.8430023f, 0.7562745f);
    }

    // Update is called once per frame
    void Update()
    {
        //takes the value of total time of sunlight available and subtracts 1per second
        float countdown = timer - Time.time;

        float countPercent = Mathf.Clamp01(countdown/timer);
        
        //applies the timer to the light intensity
        worldLight.intensity = 1.5f * countPercent;

        worldLight.color = Color.Lerp(sunset, dayLight, countPercent);


        //Debug.Log(countdown);

    }
}
