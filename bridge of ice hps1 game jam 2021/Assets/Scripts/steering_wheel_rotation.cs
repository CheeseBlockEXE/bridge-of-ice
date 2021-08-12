using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steering_wheel_rotation : MonoBehaviour
{

    float wheelAngle = 30f;
    float rotationConst = -52.999f;
    public float smoth = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float wheelMoveBy = Input.GetAxis("Horizontal") * wheelAngle;

        Quaternion targetRot = Quaternion.Euler(rotationConst, 0, wheelMoveBy);

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRot, Time.deltaTime * smoth);
        

        //Debug.Log();
    }
}
