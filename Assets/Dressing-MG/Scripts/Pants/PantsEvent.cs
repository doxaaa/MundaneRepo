using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsEvent : MonoBehaviour
{
   public void Pants()
    {
         gameObject.GetComponent<Renderer>().material.color = new Color(0.1882353f, 0.219607f, 0.2666667f);
    }

    private void OnEnable()
    {
        EventManagerMain.PantsOnTouched += Pants;
    }

    private void OnDisable()
    {
        EventManagerMain.PantsOnTouched -= Pants;
    }
}
