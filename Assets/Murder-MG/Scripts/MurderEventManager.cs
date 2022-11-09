using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurderEventManager : MonoBehaviour
{
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
}
