using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglecreepyrotation : MonoBehaviour
{
    //calls the script that makes the wheel look all shaky
    public steering_wheel_creepyrotation creepyRot;

    //a boolean to toggle when the truck is in a danger zone
    public bool isOnThinIce;


    void Update()
    {
        /*this just a debug line to toggle the effect with f4
        if(Input.GetKeyDown(KeyCode.F4))
        {
            isOnThinIce = !isOnThinIce;
            Debug.Log("pretend we're going in and out of danger territory");
        }
        */
        //toggling the janky looking wheel rotation
        if (isOnThinIce == true)
        {
            creepyRot.enabled = true;
        }
        else
        {
            creepyRot.enabled = false;
        }
    }
}
