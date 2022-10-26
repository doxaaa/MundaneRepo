using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerForPackingMinigame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public delegate void PackageAction();

    //declaring event
    public static event PackageAction PackageEvent;

    public static void PackageFunction() 
    {
    //if event is not empty
        print("event triggered!");
        if(PackageEvent != null)
        {
            PackageEvent(); //triggers the event
        }
    }
}
