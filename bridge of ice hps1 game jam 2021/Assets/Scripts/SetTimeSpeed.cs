using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTimeSpeed : MonoBehaviour
{
    public float timeMod;
    void OnEnable()
    {
        Time.timeScale=timeMod;
    }

    void OnDisable()
    {
        Time.timeScale=1;
    }
}
