using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Start is called before the first frame update
    private void update()
    {
        var x = Mathf.PingPong(Time.time, 3);
        var z = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(x, 0, z);
        transform.position = p;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(30, 30, 0) * Time.deltaTime);
        
    }
}
