using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightSky : MonoBehaviour
{

    Material nightSphere;

    Color newColor;

    public bool ignoreTimer;

    void Start()
    {
        nightSphere = GetComponent<MeshRenderer>().material;

        newColor = new Vector4(0.004049484f, 0.02766405f, 0.06603771f);
        newColor.a = 0f;
        if(ignoreTimer)
        {
            newColor.a = 1;
            nightSphere.SetColor("_MainColor", newColor);
        }
    }

    private void Update()
    {
        if(!ignoreTimer)
        {
        float countPercent = 1 - TheTimer.theTimer.counter();

        newColor.a = countPercent;

        nightSphere.SetColor("_MainColor", newColor);
        }

    }

}
