using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrownedRestart : MonoBehaviour
{
    public static DrownedRestart instance;

    public bool gotDrownd;

    private void Start()
    {
        instance = this;
        gotDrownd = false;
    }

    private void OnTriggerEnter(Collider drwnColl)
    {
        gotDrownd = true;

        ScreenSettings.instance.isPaused = true;
    }
}
