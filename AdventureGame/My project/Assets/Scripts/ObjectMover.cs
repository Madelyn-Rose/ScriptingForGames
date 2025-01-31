using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    // Start is called before the first frame update

        public float speed = 2f;
        public float distance = 3f;

    // Move the object back and forth on the x axis
    void Update()
    {
       float x = Mathf.PingPong(Time.time * speed, length:distance);
       transform.position = new Vector3(x, transform.position.y, transform.position.z); 
    }
}
