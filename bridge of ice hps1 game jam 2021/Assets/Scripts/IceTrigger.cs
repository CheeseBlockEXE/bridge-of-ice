using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceTrigger : MonoBehaviour
{

    public bool  affectSpeed;

    public bool affectPower;

    public float mod=0.7f;

    public float gameOverTime;

    float timer;

    bool inIce;



    void Update()
    {
        if(inIce)
        {
            timer+=Time.deltaTime;
        }
        if(timer>gameOverTime)
        {
            TruckEffectManager.Instance.GameOverSequence();
            inIce=false;
            timer=0;
        }
    }
    

    void OnTriggerEnter(Collider col)
    {
        inIce=true;
        TruckEffectManager.Instance.SetTruckPower(1/mod);
        TruckEffectManager.Instance.SetTruckSpeed(1/mod);
    }

    void OnTriggerExit(Collider col)
    {
        inIce =false;
        TruckEffectManager.Instance.SetTruckPower(1/mod);
        TruckEffectManager.Instance.SetTruckSpeed(1/mod);
        timer=0;
    }

    
}
