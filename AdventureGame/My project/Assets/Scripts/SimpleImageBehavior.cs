using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]

public class SimpleImageBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private Image imageObj;
    public SimpleFloatData dataObj;

    private void Start()
    {
        imageObj = GetComponent<Image>();
    }

    // Update is called once per frame
    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }
}
