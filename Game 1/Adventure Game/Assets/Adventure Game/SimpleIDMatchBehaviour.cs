using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleIDMatchBehaviour : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;
    private ColliderDestroyer ColliderDestroyerScript;
    private SimpleDoorOpener SimpleDoorOpenerScript;

    void Start()
    {
        ColliderDestroyerScript = GetComponent<ColliderDestroyer>();
        SimpleDoorOpenerScript = GetComponent<SimpleDoorOpener>();
    }
    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleIDBehaviour>();

        if (otherID != null)
        {
            if (otherID.id == id)
            {
                matchEvent.Invoke();
                Debug.Log("Matched ID: " + id);
                if (ColliderDestroyerScript != null)
                {
                    ColliderDestroyerScript.DestroyKey();
                }

                if (SimpleDoorOpenerScript != null)
                {
                    SimpleDoorOpenerScript.OpenDoor();
                }
            }
            else
            {
                noMatchEvent.Invoke();
                Debug.Log("No Match: " + id);
            }
        }
    }
}