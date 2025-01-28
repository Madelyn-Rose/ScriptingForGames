using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
    // Start is called before the first frame update
   public float rotationSpeed = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle:0, yAngle:rotationSpeed * Time.deltaTime, zAngle:0);
    }
}
