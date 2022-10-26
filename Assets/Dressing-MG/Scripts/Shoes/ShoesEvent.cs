using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoesEvent : MonoBehaviour
{
     public void Shoes()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0.02352941f, 0.02352941f, 0.02352941f);
    }

    private void OnEnable()
    {
        EventManager.ShoesOnTouched += Shoes;
    }

    private void OnDisable()
    {
        EventManager.ShoesOnTouched -= Shoes;
    }
}
