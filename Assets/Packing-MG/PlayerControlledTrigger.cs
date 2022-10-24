using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlledTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown("z"))
        {
            print("event played");
            EventManagerForPackingMinigame.PackageFunction();
        }
        */
    }   

    void OnTriggerStay(Collider CollisionData) 
    {
        print("In collison");
        if(Input.GetKeyDown("z"))   
            {

                    print("event played");
                    EventManagerForPackingMinigame.PackageFunction();


            }
        
    }
}