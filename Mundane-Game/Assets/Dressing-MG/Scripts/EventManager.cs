using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void Shirt();
    public static event Shirt ShirtOnTouched;
    public static void RunShirtEvent()
    {
        ShirtOnTouched?.Invoke();
    }

    public delegate void Pants();
    public static event Pants PantsOnTouched;
    public static void RunPantsEvent()
    {
        PantsOnTouched?.Invoke();
    }
    
    public delegate void Socks();
    public static event Socks SocksOnTouched;
    public static void RunSockEvent()
    {
        SocksOnTouched?.Invoke();
    }

    public delegate void Shoes();
    public static event Shoes ShoesOnTouched;
    public static void RunShoeEvent()
    {
        ShoesOnTouched?.Invoke();
    }
}
