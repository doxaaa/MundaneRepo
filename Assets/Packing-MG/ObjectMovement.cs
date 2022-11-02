using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private bool checkCollison = false;
    private int boxCountPacked;
    private Collider CollisionData;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if(checkCollison == false)
        {
        this.transform.position += new Vector3(.1f,0,0);
        }        
        
    }


    void OnTriggerEnter(Collider CollisionData)
    {

        if(CollisionData.name == "PackageBox")
            {
                checkCollison = true;
            }

    }




}
