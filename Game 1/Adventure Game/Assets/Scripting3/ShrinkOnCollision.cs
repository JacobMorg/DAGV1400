using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public float shrinkFactor = 0.9f;

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        // Scale the object down when it collides with another object
        transform.localScale *= shrinkFactor;
    }
}
