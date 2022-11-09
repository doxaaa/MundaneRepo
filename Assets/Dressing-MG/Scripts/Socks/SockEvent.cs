using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockEvent : MonoBehaviour
{
    public void Socks()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0.1686f, 0.1607843f, 0.2f);
    }

    private void OnEnable()
    {
        EventManagerMain.SocksOnTouched += Socks;
    }

    private void OnDisable()
    {
        EventManagerMain.SocksOnTouched -= Socks;
    }
}
