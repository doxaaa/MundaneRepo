using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockEvent : MonoBehaviour
{
    public void Socks()
    {
        Destroy(this.gameObject);
    }

    private void OnEnable()
    {
        EventManager.SocksOnTouched += Socks;
    }

    private void OnDisable()
    {
        EventManager.SocksOnTouched -= Socks;
    }
}
