using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerContainerScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public SimpleFloatData HungerData;
    // Start is called before the first frame update
    public void ReduceHunger(float amount)
    {
        HungerData.UpdateValue(amount);
    }
}
