using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoesCollider : MonoBehaviour
{
   void OnTriggerEnter(Collider CollisionData)
    {
        if (CollisionData.name == "RightFoot")
        {
            EventManager.RunShoeEvent();
            print("Socks Put On");

            Destroy(this.gameObject);
        }
    }  
}
