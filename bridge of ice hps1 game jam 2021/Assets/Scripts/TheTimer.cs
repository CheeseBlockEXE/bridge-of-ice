using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheTimer : MonoBehaviour
{
    //THIS IS THE TIMER THAT SETS HOW LONG UNTIL IT GETS DARK (in seconds)
    private float timer = 15;
    
    public float counter()
    {
        float countdown = timer - Time.time;
        float countPercent = Mathf.Clamp01(countdown / timer);

        return countPercent;
    }

}
