using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider CollisionData)
    {
        if (CollisionData.name == "Chest")
        {
            EventManager.RunShirtEvent();
            print("Shirt Put On");

            Destroy(this.gameObject);
        }
    }  
}
