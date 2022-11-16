using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public delegate void CardSwipe();
    public static event CardSwipe ClockIn;
    public static void RunCardSwipe()
    {
        ClockIn?.Invoke();
    }
}
