using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightSky : MonoBehaviour
{

    Material nightSphere;

    private TheTimer theTimer;

    Color newColor;

    private void Awake()
    {
        theTimer = GetComponent<TheTimer>();
    }

    void Start()
    {
        nightSphere = GetComponent<MeshRenderer>().material;

        newColor = new Vector4(0.004049484f, 0.02766405f, 0.06603771f);
        newColor.a = 0f;
    }

    private void Update()
    {
        float countPercent = 1 - theTimer.counter();

        newColor.a = countPercent;

        nightSphere.SetColor("_MainColor", newColor);
    }

}