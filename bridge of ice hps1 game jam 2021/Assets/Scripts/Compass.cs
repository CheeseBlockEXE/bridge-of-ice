using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Transform TruckDir;
    float compDir;


    private void Update()
    {
        compDir = TruckDir.eulerAngles.y;
        transform.localEulerAngles = new Vector3(0, -compDir, 0);
    }
}
