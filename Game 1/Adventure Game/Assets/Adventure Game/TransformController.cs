using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        //Move Game object
        var x = Mathf.PingPong(Time.time, 10);
        var p = new Vector3(83.77628f + x, -1.955248f, 0);
        transform.position = p;
    }
}

