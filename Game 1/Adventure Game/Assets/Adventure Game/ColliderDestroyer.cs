using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDestroyer : MonoBehaviour
{
    private Collider myCollider;

    void start()
    {
        myCollider = GetComponent<Collider>();
    }

    public void Destroyer(GameObject gameObject)
    {
        Destroy(myCollider);
    }
}
