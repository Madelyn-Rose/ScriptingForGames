using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowOnCollision : MonoBehaviour
{
     public float growthFactor = 2f;

    void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= growthFactor;
    }
}
