using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSettings : MonoBehaviour
{
    public int framerate;
    
    void Start()
    {
        Application.targetFrameRate = framerate;
    }

}
