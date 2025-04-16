using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private Collider myCollider;
    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    public void Destroyer(GameObject gameObject)
    {
        Destroy(myCollider);
        Object.Destroy(gameObject ,2f);
    }
}
