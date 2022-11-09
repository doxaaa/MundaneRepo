using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlledTrigger : MonoBehaviour
{
    private int movingBoxObjectNameChange;
    // Start is called before the first frame update
    void Start()
    {
        movingBoxObjectNameChange = 0;
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
        if(CollisionData.name == "MovingObject("+movingBoxObjectNameChange+")")
        print("In collison");
        movingBoxObjectNameChange = movingBoxObjectNameChange + 1;
        if(Input.GetKeyDown("z"))   
            {

                    print("event played");
                    EventManagerMain.PackageFunction();


            }
        
    }
}