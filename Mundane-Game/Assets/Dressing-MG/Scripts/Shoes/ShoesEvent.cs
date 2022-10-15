using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoesEvent : MonoBehaviour
{
     public void Shoes()
    {
        Destroy(this.gameObject);
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
