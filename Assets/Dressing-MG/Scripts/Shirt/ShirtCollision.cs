using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider CollisionData)
    {
        if (CollisionData.name == "Chest")
        {
            EventManagerMain.RunShirtEvent();
            EventManagerMain.DressingWinFunction();
            print("Shirt Put On");

            Destroy(this.gameObject);
        }
    }  
}
