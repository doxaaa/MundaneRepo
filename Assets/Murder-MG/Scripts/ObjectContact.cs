using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectContact : MonoBehaviour
{
    public MurderManager myMurderManager;
    

    void OnTriggerEnter(Collider CollisionData)
    {
        if(CollisionData.name == "cube");
        {
            myMurderManager.DestroyMovingObject();
        }
    }
}
