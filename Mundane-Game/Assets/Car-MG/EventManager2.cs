using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public delegate void CrashAction();

    //declaring event
    public static event CrashAction CrashEvent;

    public static void CrashFunction()
    {
    //if event is not empty
        print("event triggered!");
        SceneManager.LoadScene("CarMG");
        if (CrashEvent != null)
        {
            CrashEvent(); //triggers the event
        }
    }
    public delegate void ResetAction();

    //declaring event
    public static event ResetAction ResetEvent;

    public static void ResetFunction()
    {
    //if event is not empty
        print("event triggered!");
        if(ResetEvent != null)
        {
            ResetEvent(); //triggers the event
        }
    }
        public delegate void WinAction();

    //declaring event
    public static event WinAction WinEvent;

    public static void WinFunction()
    {
    //if event is not empty
        print("event triggered!");
        SceneManager.LoadScene("MurderMG");
        if (WinEvent != null)
        {
            WinEvent(); //triggers the event
        }
    }
}

