using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent winEvent;


    void OnTriggerEnter()
    {

        winEvent.Invoke();
    }
}
