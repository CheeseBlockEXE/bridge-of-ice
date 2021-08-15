using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckEffectManager : MonoBehaviour
{
    static public TruckEffectManager Instance;

    public TruckFPS truck;
    public List<Collider> groundCol;

    void Awake()
    {
Instance=this;
    }


    public void SetTruckPower(float mod)
    {
            
            truck.power= truck.power*mod;
    }

    public void SetTruckSpeed(float mod)
    {

    truck.rb.velocity= truck.rb.velocity*mod;

    }

    public void TurnOffGroundColliders()
    {
        for(int i=0; i<groundCol.Count;i++)
        {

            groundCol[i].enabled=false;
        }
    }


    public void GameOverSequence()
    {

        TurnOffGroundColliders();
        ///do whatever else here
    }


}
