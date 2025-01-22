using UnityEngine;
public class ApplyForce : MonoBehavior
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>()
        rb.AddForce(vector3.right * 500);
    }
}