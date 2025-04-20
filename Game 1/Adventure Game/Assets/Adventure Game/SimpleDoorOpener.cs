using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDoorOpener : MonoBehaviour
{
    public GameObject KeyObject;
    public GameObject door;
    public float openDistance = 3f;
    public float openSpeed = 2f;
    private bool isOpening = false;
    private Vector3 startPosition;
    private Vector3 endPosition;

    void Start()
    {
        if (door == null)
        {
            door = gameObject;
        }

        startPosition = door.transform.position;
        endPosition = startPosition + new Vector3(0f, openDistance, 0f) * openDistance;
    }

    public void DestroyKey()
    {
        //destroys key
        Destroy(KeyObject);
    }

    public void OpenDoor()
    {
        Debug.Log("Open door");
        isOpening = true;
    }

    void Update()
    {
        if (isOpening)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, endPosition, openSpeed * Time.deltaTime);
            if (Vector3.Distance(door.transform.position, endPosition) < 0.01f)
            {
                isOpening = false;
            }
        }
    }
}
