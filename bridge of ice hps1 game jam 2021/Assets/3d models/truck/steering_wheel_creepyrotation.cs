using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steering_wheel_creepyrotation : MonoBehaviour
{

    float rotationConst = -142.999f;

    float wheelAngle = 120f;
    float damp= 3f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        float wheelMoveBy = Input.GetAxis("Horizontal") * wheelAngle;

        Quaternion target = Quaternion.Euler(rotationConst, 0, wheelMoveBy);
        Quaternion ogPos = Quaternion.Euler(rotationConst, 0, 0);

        transform.rotation = Quaternion.Slerp(ogPos, target, Time.deltaTime * damp);

       // Debug.Log("GetAxis: " + wheelMoveBy);
    }
}