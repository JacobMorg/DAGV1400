using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    public Color newColor = Color.blue;

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        // Change the object's color upon collision with another GameObject
        GetComponent<Renderer>().material.color = newColor;
    }
}
