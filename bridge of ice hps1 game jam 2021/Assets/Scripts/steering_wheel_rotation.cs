using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steering_wheel_rotation : MonoBehaviour
{
    static public steering_wheel_rotation WheelRotationInst;
    private steering_wheel_creepyrotation creepyRot;

    float wheelAngle;
    float rotationConst = -52.999f;
    public float smoth = 10f;

    public bool isOnIce;

    private void Awake()
    {
        WheelRotationInst = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        creepyRot = GetComponent<steering_wheel_creepyrotation>();
        wheelAngle = 30f;
    }

    // Update is called once per frame
    void Update()
    {

        float wheelMoveBy = Input.GetAxis("Horizontal") * wheelAngle;            

        Quaternion targetRot = Quaternion.Euler(rotationConst, 0, wheelMoveBy);

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRot, Time.deltaTime * smoth);

        ///debug that switches to the jittery wheel with F4
        /*
        if (Input.GetKeyDown(KeyCode.F4))
        {
            isOnIce = !isOnIce;
            Debug.Log("pretend we're goin in n out of ice");
        }*/


        ///toggling the janky looking wheel rotation
        if (isOnIce == true)
        {
            creepyRot.enabled = true;
        }
        else
        {
            creepyRot.enabled = false;
        }

    }
}
