using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleIDMatchBehaviour : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;
    private ColliderDestroyer ColliderDestroyerScript;

    void Start()
    {
        ColliderDestroyerScript = GetComponent<ColliderDestroyer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleIDBehaviour>();

        if (otherID.id == id)
        {
            matchEvent.Invoke();
            Debug.Log("Matched ID: " + id);
            ColliderDestroyerScript.DestroyKey();
        }
        else
        {
            noMatchEvent.Invoke();
            Debug.Log("No Match: " + id);
        }
    }
}