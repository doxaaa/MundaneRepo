using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider CollisionData)
    {
        if (CollisionData.name == "RightLeg")
        {
            EventManagerMain.RunPantsEvent();
            EventManagerMain.DressingWinFunction();
            print("Pants Put On");

            Destroy(this.gameObject);
        }
    }  
}
