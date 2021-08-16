using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceTrigger : MonoBehaviour
{

    public bool  affectSpeed;

    public bool affectPower;

    public bool affectSteer;
    public bool playIceSFX;

    public bool PlaySnowSfx;

    public float mod=0.7f;

    public float gameOverTime;



    float timer=15;

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
        if(affectSteer)
        {
            TruckEffectManager.Instance.SetRandomSteer(true);
        }

        if(playIceSFX)
        TruckEffectManager.Instance.PlayIceCracking();
        if(PlaySnowSfx)
        TruckEffectManager.Instance.PlaySnowSfx();
    }

    void OnTriggerExit(Collider col)
    {
        Debug.Log("Ice Exited");
        inIce =false;
        if(affectPower)
        TruckEffectManager.Instance.SetTruckPower(1/mod);
        if(affectSpeed)
        
        TruckEffectManager.Instance.SetTruckSpeed(1/mod);
        if(affectSteer)
        {
            TruckEffectManager.Instance.SetRandomSteer(false);
        }
        if(playIceSFX)
        TruckEffectManager.Instance.StopIceCracking();
        if(PlaySnowSfx)
        TruckEffectManager.Instance.StopSnowSfx();
        timer=0;
    }

    
}
