using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent triggerEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        Debug.Log("Player interacted with the Slime!!");
        
    }
}
