using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnter : MonoBehaviour
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
        print("event played");
        EventManagerForPackingMinigame.PackageFunction();
    }
}
