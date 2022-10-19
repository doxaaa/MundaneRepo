using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsEvent : MonoBehaviour
{
   public void Pants()
    {
        Destroy(this.gameObject);
    }

    private void OnEnable()
    {
        EventManager.PantsOnTouched += Pants;
    }

    private void OnDisable()
    {
        EventManager.PantsOnTouched -= Pants;
    }
}
