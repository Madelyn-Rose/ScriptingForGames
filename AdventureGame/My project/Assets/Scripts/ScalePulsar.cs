using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalePulsar : MonoBehaviour
{
    // Start is called before the first frame update
    public float pulseSpeed = 2f;
    public float maxScale = 1.5f;
    public float minScale = 0.5f;

    // Update is called once per frame
    void Update()
    {
        float scale = Mathf.PingPong(t:Time.time * pulseSpeed, length:maxScale - minScale) + minScale;
        transform.localScale = new Vector3(x:scale, y:scale, z:scale);
    }
}
