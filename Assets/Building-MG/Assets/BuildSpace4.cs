using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSpace4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collisionObject)
    {
        if (collisionObject.name == "Part Four")
        {
            EventManagerMain.RunCorrectPart();
        }
    }
}
