using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRes : MonoBehaviour
{
    private void Start()
    {
        Screen.SetResolution(640, 480, true, 21);
        PlayerPrefs.DeleteAll();
    }
}
