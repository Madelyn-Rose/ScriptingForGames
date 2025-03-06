using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]

public class SimpleImageBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private Image imageObj;

    public SimpleFloatData dataObj;
    public SimpleIntData scoreBonus;
    public UnityEvent triggerEvent;

    private void Start()
    {
        imageObj = GetComponent<Image>();
    }
    private void Update()
    {
        FullOrange();
    }
    // Update is called once per frame
    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }
    void FullOrange()
    {
        if (dataObj.value >= 1f)
        {
            triggerEvent.Invoke();
            dataObj.value = 0f;
            Debug.Log("full orange");
        }
    }
}
