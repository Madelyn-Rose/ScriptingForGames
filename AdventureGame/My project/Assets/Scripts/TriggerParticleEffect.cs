using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem),typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particleSystem; //Reference Particle System
    public int particleAmount = 10; //Exposed variable for particle amount
    
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) //Check if player triggered event
        {
            particleSystem.Emit(particleAmount); //Emit the specified number of particles
        }
    }
}
