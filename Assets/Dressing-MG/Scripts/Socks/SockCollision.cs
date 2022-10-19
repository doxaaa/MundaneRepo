using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockCollision : MonoBehaviour
{
   void OnTriggerEnter(Collider CollisionData)
    {
        if (CollisionData.name == "RightSock")
        {
            EventManager.RunSockEvent();
            print("Socks Put On");

            Destroy(this.gameObject);
        }
    }  
}
