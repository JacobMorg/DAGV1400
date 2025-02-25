using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    public SimpleFloatData healthdata;

    public void ReduceHealth(float amount)
    {
        healthdata.UpdateValue(amount);
    }
}
