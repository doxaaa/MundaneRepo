using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTextTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider CollisionData) 
    {
            if(CollisionData.name == "Player")
        {
            print("Remove Text");

            EventManager2.ResetFunction();

        }
    }

}
