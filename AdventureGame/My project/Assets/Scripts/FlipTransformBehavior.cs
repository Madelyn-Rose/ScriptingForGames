using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipTransformBehavior : MonoBehaviour
{
    // Start is called before the first frame update
   public KeyCode key1 = KeyCode.RightArrow, key2 = KeyCode.LeftArrow;
   public float direction1 = 0, direction2 = 180;
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(key1))
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }
        if (!Input.GetKeyDown(key2)) return;
        transform.rotation = Quaternion.Euler(0, direction2, 0);
    }
}
