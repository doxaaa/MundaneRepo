using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtEvent : MonoBehaviour
{
    public void Shirt()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0.8431373f, 0.8352942f, 0.8588236f);
    }

    private void OnEnable()
    {
        EventManager.ShirtOnTouched += Shirt;
    }

    private void OnDisable()
    {
        EventManager.ShirtOnTouched -= Shirt;
    }
}
