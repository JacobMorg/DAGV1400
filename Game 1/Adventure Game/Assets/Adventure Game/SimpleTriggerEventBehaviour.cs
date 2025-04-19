using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;
    public UnityEvent staminaEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Trigger the event and test with a debug message
            triggerEvent.Invoke();
            Debug.Log("Player interacted with the object!");
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            staminaEvent.Invoke();
            Debug.Log("Player tried to jump!");
        }
    }
}
