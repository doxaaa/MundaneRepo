using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtEvent : MonoBehaviour
{
    public void Shirt()
    {
        Destroy(this.gameObject);
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
