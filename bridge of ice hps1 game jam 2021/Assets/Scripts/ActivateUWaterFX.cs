using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUWaterFX : MonoBehaviour
{
    public GameObject compass;
    public GameObject waterSphere;
    public GameObject splash;
    public GameObject uwaSounds;
    public GameObject aboveSounds;

    private void Start()
    {
        waterSphere.SetActive(false);
    }

    private void OnTriggerEnter(Collider h2o)
    {
        compass.SetActive(false);
        waterSphere.SetActive(true);
        splash.SetActive(true);
        uwaSounds.SetActive(true);
        aboveSounds.SetActive(false);
    }
}
