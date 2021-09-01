using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    public AudioSource mouseSfx;
    public AudioClip menScrl;
    public AudioClip menSlct;

    public void Scrl()
    {
        mouseSfx.PlayOneShot(menScrl);
    }

    public void Slct()
    {
        mouseSfx.PlayOneShot(menSlct);
    }

}
