using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheTimer : MonoBehaviour
{
    static public TheTimer theTimer;

    public bool isNight;

    
    private void Awake()
    {
        theTimer = this;
    }

    //THIS IS THE TIMER THAT SETS HOW LONG UNTIL IT GETS DARK (in seconds)
    float timer = 360;

    public float counter()
    {
        float countdown = timer - Time.timeSinceLevelLoad;
        float countPercent = Mathf.Clamp01(countdown / timer);

        return countPercent;
    }

    private void Update()
    {
        if (counter() == 0)
            isNight = true;
        else
            isNight = false;
    }
}
