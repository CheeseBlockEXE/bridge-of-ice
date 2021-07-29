using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand_IK_follow_wheel : MonoBehaviour
{
    //grabs the source where the ik platform should be attached
    public GameObject wheelpos;


    void LateUpdate()
    {
        //snaps the ik platform into the source
        transform.position = wheelpos.transform.position;
        transform.rotation = wheelpos.transform.rotation;
    }
}