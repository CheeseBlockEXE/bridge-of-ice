using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FogColorChange : MonoBehaviour
{

    Volume nightWeight;

    void Start()
    {
        nightWeight = GetComponent<Volume>();

        nightWeight.weight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float countPercent = 1- TheTimer.theTimer.counter();

        nightWeight.weight = countPercent;
    }
}
