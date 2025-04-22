using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollider : MonoBehaviour
{
    private Collider myCollider;
    private Renderer myRenderer;

    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRenderer = GetComponent<SpriteRenderer>();
    }

    public void Destroyer(GameObject target)
    {
        Destroy(myCollider);
        Destroy(myRenderer, .5f);
        Destroy(target, .8f);
    }
}
