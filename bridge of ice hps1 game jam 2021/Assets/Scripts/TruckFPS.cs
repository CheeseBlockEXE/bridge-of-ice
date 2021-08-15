using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckFPS : MonoBehaviour
{
    [Tooltip("Place steering wheels first and second.")]
    [SerializeField] WheelCollider[] wheels;
    [Tooltip("Power per wheel. \nAffects top speed along with drag, distributed among all wheels.")]
    public float power = 10000;
    [Tooltip("Maximum steering angle.")]
    [SerializeField] float maxSteer = 30;
    [Tooltip("Center Of Mass. \nRight in the middle of all the wheels on the x-z plane and road height for best handling.")]
    [SerializeField] Transform COM;
    [Tooltip("Multiple of max steer.\nMaximum wheel rotation while snowy.")]
    [SerializeField] float snowTyreRandomnessMult=1.5f;
    [Tooltip("Multiple of max steer.\nMaximum rotation offset, value 1 can be kept straight even at max, >1 for less control, <1 for more.")]
    [SerializeField] float snowTyreMaxDeviationMult = 1f;
    float randomSteer;
    [HideInInspector]public bool snowTyre; //activate this to randomly mess with steering.
    public Rigidbody rb;

    void Start()
    {
        if(rb==null)
        {
        rb = GetComponent<Rigidbody>();
        if(COM!=null)
            rb.centerOfMass = COM.position;
        }
    }

    void Update()
    {
        float steerAmount = Mathf.Clamp( maxSteer * Input.GetAxis("Horizontal")+randomSteer,maxSteer* -snowTyreRandomnessMult, maxSteer * snowTyreRandomnessMult);
        
        wheels[0].steerAngle = steerAmount;
        wheels[1].steerAngle = steerAmount;
    }

    private void FixedUpdate()
    {
        if (!snowTyre)
            randomSteer = 0;
        else
            randomSteer = Mathf.Clamp(randomSteer+Random.Range(-0.5f, 0.5f),maxSteer * -snowTyreMaxDeviationMult, maxSteer * snowTyreMaxDeviationMult);

        foreach (WheelCollider wheel in wheels)
        {
            wheel.motorTorque = power/wheels.Length;
        }
    }
}
