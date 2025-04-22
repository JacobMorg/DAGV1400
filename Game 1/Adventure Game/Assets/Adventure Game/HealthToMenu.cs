using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthToMenu : MonoBehaviour
{
    public SimpleFloatData dataObj;
    private bool hasTriggered = false;

    public void Update()
    {
        if (!hasTriggered && dataObj.value <= 0)
        {
            hasTriggered = true;
            SceneManager.LoadScene(0);
        }
    }
}
