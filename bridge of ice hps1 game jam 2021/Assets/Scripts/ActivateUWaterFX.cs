using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUWaterFX : MonoBehaviour
{
    public GameObject compass;
    public GameObject waterSphere;

    private void Start()
    {
        waterSphere.SetActive(false);
    }

    private void OnTriggerEnter(Collider h2o)
    {
        compass.SetActive(false);
        waterSphere.SetActive(true);
    }
}
