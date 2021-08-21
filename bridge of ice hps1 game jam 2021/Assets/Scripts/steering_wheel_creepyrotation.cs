using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steering_wheel_creepyrotation : MonoBehaviour
{

    float rotationConst = -52.999f;

    float wheelAngle = 120f;
    float smoth = 2f;

    // Update is called once per frame
    void Update()
    {

        float jitter = Random.value * 10;

        float wheelMoveBy = Input.GetAxis("Horizontal") * wheelAngle;

        float jitterWheel = jitter * wheelMoveBy + jitter * 5f;

        Quaternion target = Quaternion.Euler(rotationConst, 0, jitterWheel);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * smoth);


    }
}