using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BarMovement : MonoBehaviour
{
    public Vector3 userInput;
    Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        userInput = new Vector3(0,0,Input.GetAxis("Vertical")); // gets horizontal movement keys
        rb.velocity = this.transform.forward*userInput.z*speed ; //moves player via transform position for now
    }


}
