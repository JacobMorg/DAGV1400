using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDoorOpener : MonoBehaviour
{
    public GameObject KeyObject;
    public GameObject door;

    public void DestroyKey()
    {
        //destroys key
        Destroy(KeyObject);
    }


}
