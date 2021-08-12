using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FogColorChange : MonoBehaviour
{

    Volume nightWeight;

    private TheTimer theTimer;


    private void Awake()
    {
        theTimer = GetComponent<TheTimer>();
    }

    void Start()
    {
        nightWeight = GetComponent<Volume>();

        nightWeight.weight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float countPercent = 1-theTimer.counter();

        nightWeight.weight = countPercent;
    }
}
