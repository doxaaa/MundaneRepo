using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider CollisionData)
    {
        if (CollisionData.name == "RightLeg")
        {
            EventManager.RunPantsEvent();
            print("Pants Put On");

            Destroy(this.gameObject);
        }
    }  
}
