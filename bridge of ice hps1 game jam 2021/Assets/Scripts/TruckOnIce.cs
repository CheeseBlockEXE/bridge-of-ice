using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckOnIce : MonoBehaviour
{
    static public TruckOnIce Instance;
    private TruckFPS truckFps;
    public GameObject roadColl;
    public GameObject truckRuninHot;
    public GameObject iceCrack1FX;
    public GameObject iceCrack2FX;

    public bool inIce;

    private float gameOverTime = 5;

    float timer;
    public bool gameOverd;


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
        

        ///checks boolean inIce (which should be controled by RoadTrigger.cs)
        ///and starts the timer, then multiplies the truck's power by the inverse of the timer
        ///so the longer the player goes offroad, the lower the truck power
        if (inIce == true)
        {
            timer += Time.deltaTime;
            float modVal = (mod - (timer /gameOverTime)) * 3;
            truckFps.power = truckPower * modVal;
            iceCrack1FX.SetActive(true);
        }
        else
        {
            timer = 0;
            truckFps.power = truckPower;
            iceCrack1FX.SetActive(false);
        }

        ///once the timer reaches game over, the truck power is set to 0 
        ///but won't initiate the full gameover sequence until the truck is completely stopped
        if (timer > gameOverTime)
        {
            truckPower = 0;
            gameOverd = true;
            truckRuninHot.SetActive(true);
        }

        ///starts the full gameover sequence once the truck is stopped
        if(truckFps.rb.velocity.z <= 1.2f && gameOverd == true)
        {
            timer = 0;
            inIce = false;
            gameOverd = false;
            roadColl.SetActive(false);
            TruckEffectManager.Instance.GameOverSequence();
            iceCrack2FX.SetActive(true);

            Debug.Log("now u done snuffed it");
        }

        //Debug.Log(timer);
    }
}
