using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthContainerScript : MonoBehaviour
{
    public SimpleFloatData healthData;
    // Start is called before the first frame update
    public void ReduceHealth(float amount)
    {
        healthData.UpdateValue(amount);
    }

   
}
