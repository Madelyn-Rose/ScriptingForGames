using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/SimpleIntData")]
public class SimpleIntData : MonoBehaviour
{
    
    public int value;
    public void UpdateValue(int amount)
    {
        value += amount;
    }

    // Update is called once per frame
    public void SetValue(int amount)
    {
        value = amount;
    }
}
