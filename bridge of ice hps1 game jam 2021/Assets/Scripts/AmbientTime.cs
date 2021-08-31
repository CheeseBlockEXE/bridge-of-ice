using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientTime : MonoBehaviour
{
    public AudioSource ambient;

    private void Update()
    {
        ambient.volume = 1 - TheTimer.theTimer.counter();
    }


}
