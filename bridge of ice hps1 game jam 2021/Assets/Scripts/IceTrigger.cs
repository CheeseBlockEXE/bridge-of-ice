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
        Debug.Log("Ice Entered");
        inIce=true;
        if(affectPower)
        TruckEffectManager.Instance.SetTruckPower(mod);
        if(affectSpeed)
        TruckEffectManager.Instance.SetTruckSpeed(mod);
    }

    void OnTriggerExit(Collider col)
    {
        Debug.Log("Ice Exited");
        inIce =false;
        if(affectPower)
        TruckEffectManager.Instance.SetTruckPower(1/mod);
        if(affectSpeed)
        TruckEffectManager.Instance.SetTruckSpeed(1/mod);
        timer=0;
    }

    
}
