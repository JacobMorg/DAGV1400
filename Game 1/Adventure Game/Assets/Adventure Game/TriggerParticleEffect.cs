using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particleSystem; //Reference to the particle system
   
    public int firstEmissionAmount = 10; // public variable for first emission
    public int secondEmissionAmount = 20; // public variable for second emission
    public int thirdEmissionAmount = 30; // public variable for third emission
    public float delayBetweenEmissions = 0.5f; // time between emissions

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
            //sees if the object with the character controller triggers the event
        {
            StartCoroutine(EmitParticlesCoroutine());
        }
    }
    
    // Coroutine to emit particles with delay
    private IEnumerator EmitParticlesCoroutine()
    {
        //first
        particleSystem.Emit(firstEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);
        
        //second
        particleSystem.Emit(secondEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);
        
        //third
        particleSystem.Emit(thirdEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);
    }
}
