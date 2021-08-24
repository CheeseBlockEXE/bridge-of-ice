using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckOnIce : MonoBehaviour
{
    static public TruckOnIce Instance;
    private TruckFPS truckFps;

    public bool inIce;

    private float gameOverTime = 5;

    float timer;

    public bool playIceSFX;
    public bool PlaySnowSfx;

    float mod = 0.2f;
    public float truckPower;

    private void Awake()
    {
        Instance = this;
        truckFps = GetComponent<TruckFPS>();
    }
    private void Start()
    {
        truckPower = 10000f;
    }
    void Update()        
    {
        Vector3 checkVel = truckFps.rb.velocity;
        Vector3 noVel = new Vector3(0, 0, 0);

        ///checks boolean inIce (which should ONLY be controled by RoadTrigger.cs)
        ///and starts the timer, then multiplies the truck's power by the inverse of the timer
        ///so the longer the player goes offroad, the lower the truck power
        if (inIce == true)
        {
            timer += Time.deltaTime;
            float modVal = (mod - (timer /gameOverTime)) * 5;
            truckFps.power = truckPower * modVal;            
        }
        else
        {
            timer = 0;
            truckFps.power = truckPower;
        }

        ///once the timer reaches game over, the truck power is set to 0 
        ///but won't initiate the full gameover sequence until the truck is completely stopped
        if (timer > gameOverTime && inIce == true)
        {
            timer = 0;
            truckPower = 0;

            Debug.Log("game over bro");
        }

        Debug.Log(truckFps.power);

        ///initiates the game over sequence only if the truck speed reaches 0
        if (checkVel == noVel)
        {
            TruckEffectManager.Instance.GameOverSequence();
            checkVel = new Vector3(1, 1, 1);

            Debug.Log("now u done snuffed it");
        }
        
    }
}
