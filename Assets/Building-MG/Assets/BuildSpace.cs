using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSpace : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    //Vector3 m_YAxis;
    //float m_Speed;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collisionObject)
    {
        if (collisionObject.name == "Part One")
        {
            EventManagerBuild.RunCorrectPart();
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
