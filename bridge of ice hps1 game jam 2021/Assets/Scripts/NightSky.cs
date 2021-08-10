using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightSky : MonoBehaviour
{

    Material nightSphere;

    public float timer;

    Color newColor;

    void Start()
    {
        nightSphere = GetComponent<MeshRenderer>().material;

        newColor = new Vector4(0.004049484f, 0.02766405f, 0.06603771f);
    }

    private void Update()
    {
        float countdown = timer - Time.time;
        float countPercent = Mathf.Clamp01(1 - (countdown / timer));

        newColor.a = countPercent;

        nightSphere.SetColor("_MainColor", newColor);     

    }

}
