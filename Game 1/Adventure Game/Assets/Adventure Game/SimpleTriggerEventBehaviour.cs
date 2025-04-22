using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Trigger the event and test with a debug message
            triggerEvent.Invoke();
            //Debug.Log("Player interacted with the object!");
        }
    }
}
