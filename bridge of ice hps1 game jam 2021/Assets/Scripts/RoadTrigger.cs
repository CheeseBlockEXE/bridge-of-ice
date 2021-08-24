using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTrigger : MonoBehaviour
{
    ///this is the script that'll go on all the road colliders
    ///and all it does is turn on/off the boolean that's on TruckOnIce.cs which will be assigned to the truck object
    ///and TruckOnIce.cs will be the one that controls all the behaviours of truck speed, steer random, etc
    void OnTriggerExit(Collider col)
    {
        steering_wheel_rotation.WheelRotationInst.isOnIce = true;
        TruckOnIce.Instance.inIce = true;
        Debug.Log("Ice Entered");
    }

    void OnTriggerStay(Collider col)
    {
        //if (TruckOnIce.Instance.inIce == true)
          //  TruckOnIce.Instance.truckPower = 10000;
        steering_wheel_rotation.WheelRotationInst.isOnIce = false;
        TruckOnIce.Instance.inIce = false;
        //Debug.Log("Ice Exited");
    }

}
