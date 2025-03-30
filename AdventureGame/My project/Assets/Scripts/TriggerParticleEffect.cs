using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem),typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particleSystem; //Reference Particle System
    
    public int firstEmmisionAmmount = 10; //Exposed variable for first emmision
    public int secondEmmisionAmount = 20; //Exposed variable for second emmision
    public int thirdEmmisionAmount = 30; //Exposed variable for third emmision
    public float delayBetweenEmmisions = 0.5f; //Delay time between emmisions

    
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
            StartCoroutine(EmitParticlesCoroutine()); //Emit the specified number of particles
        }
    }
    private IEnumerator EmitParticlesCoroutine()
    {
        //First Emmision
        particleSystem.Emit(firstEmmisionAmmount);//Emit based on exposed variable
        yield return new WaitForSeconds(delayBetweenEmmisions); //wait a specified time
        //Second Emmision
        particleSystem.Emit(secondEmmisionAmount);
        yield return new WaitForSeconds(delayBetweenEmmisions);
        //Third Emmision
        particleSystem.Emit(thirdEmmisionAmount);
    }
}
