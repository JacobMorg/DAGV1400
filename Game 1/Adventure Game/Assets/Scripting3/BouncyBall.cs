using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    // Start is called before the first frame update
    public float bounceForce = 3f;
    
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
    }
}
