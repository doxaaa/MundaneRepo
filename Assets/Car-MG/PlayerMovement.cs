using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 userInput;
    Rigidbody rb;
    public float speed;
    public bool playerCrash;
    // Start is called before the first frame update
    void Start()
    {
        playerCrash = false; 
        rb = this.GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        userInput = new Vector3(Input.GetAxis("Horizontal"),0,0); // gets horizontal movement keys
        if(playerCrash == false )
        {   
            rb.velocity = this.transform.right*userInput.x*speed ; //moves player via transform position for now
        }

    }
    void PlayerCrashesCar()
    {
        playerCrash = true;
        rb.velocity = this.transform.right*userInput.x/speed ;

    }

    void OnEnable()
    {
        EventManagerMain.CrashEvent += PlayerCrashesCar; //adds player crash to crashEvent
    }

    void OnDisable()
    {
        EventManagerMain.CrashEvent -= PlayerCrashesCar;//removes player crash to crashEvent
    }
    
}
