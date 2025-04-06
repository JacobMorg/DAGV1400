using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDestroyer : MonoBehaviour
{
    public GameObject KeyObject;
    public GameObject trap;
    private BoxCollider trapCollider;

    void Start()
    {
        trapCollider = trap.GetComponent<BoxCollider>();
    }

    public void DestroyKey()
    {
        //destroys key
        Destroy(KeyObject);

        if (trapCollider != null) //checks to see if the collider is active
        {
            trapCollider.enabled = false; //Disable collider to stop damage
        }
    }


}
