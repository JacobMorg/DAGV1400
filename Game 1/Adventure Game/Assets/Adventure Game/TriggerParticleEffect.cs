using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particleSystem; //Reference to the particle system
    public int particleAmount = 10; // public variable that changes particle amount

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
            //sees if the object with the character controller triggers the event
        {
            particleSystem.Emit(particleAmount); //Emits the amount stated previously
        }
    }
}
