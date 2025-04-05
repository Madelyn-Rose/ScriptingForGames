using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SimpleIDMatchBehavior : MonoBehaviour
{
    public ID id;
    public UnityEvent matchEvent, mismatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleIDBehavior>();
        if (otherID.id == id)
        {
            matchEvent.Invoke();
            Debug.Log ("Matchced ID;" + id);
        }
        else
        {
            mismatchEvent.Invoke();
            Debug.Log ("Mismatched ID:" + id);
        }
    }

}
