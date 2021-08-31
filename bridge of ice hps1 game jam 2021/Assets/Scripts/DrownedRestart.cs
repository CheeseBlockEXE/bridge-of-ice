using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrownedRestart : MonoBehaviour
{
    private void OnTriggerEnter(Collider drwnColl)
    {
        SceneManager.LoadScene("Main Gameplay Scenario");
    }
}
