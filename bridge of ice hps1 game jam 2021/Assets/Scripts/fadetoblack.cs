using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadetoblack : MonoBehaviour
{
    public GameObject blkImg;

    private void Start()
    {
        blkImg.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        blkImg.SetActive(true);
    }
}
