using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public delegate void ObjectPlacement();
    public static event ObjectPlacement BuildObject;
    public static void RunCorrectPart()
    {
        BuildObject?.Invoke();
    }

    
    public delegate void CrashAction();

    //declaring event
    public static event CrashAction CrashEvent;

    public static void CrashFunction()
    {
    //if event is not empty
        print("event triggered!");
        //SceneManager.LoadScene("CarMG");
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
        //SceneManager.LoadScene("MurderMG");
        if (WinEvent != null)
        {
            WinEvent(); //triggers the event
        }
    }

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

    public delegate void MovePlayer();
    public static event MovePlayer OnMovePlayer;
    public static void RunMovePlayerEvent()
    {
        OnMovePlayer?.Invoke();
    }

    public delegate void KillCoworker();
    public static event KillCoworker OnKillCoworker;
    public static void RunKillCoworkerEvent()
    {
        OnKillCoworker?.Invoke();
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

    public delegate void LoadSceneAction();

    //declaring event
    public static event LoadSceneAction LoadSceneEvent;

    public static void LoadSceneFunction() 
    {
    //if event is not empty
        print("event triggered!");
        if(LoadSceneEvent != null)
        {
            LoadSceneEvent(); //triggers the event
        }
    }

    public delegate void DressingWinAction();

    //declaring event
    public static event DressingWinAction DressingWinEvent;

    public static void DressingWinFunction() 
    {
    //if event is not empty
        print("event triggered!");
        if(DressingWinEvent != null)
        {
            DressingWinEvent(); //triggers the event
        }
    }

    public delegate void CardSwipe();
    public static event CardSwipe ClockIn;
    public static void RunCardSwipe()
    {
        ClockIn?.Invoke();
    }
}
