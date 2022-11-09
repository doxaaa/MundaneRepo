using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public bool CarCrashesIntoPlayer;
    void Start()
    {
        CarCrashesIntoPlayer = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(CarCrashesIntoPlayer == false) // if the bool for moving elevator is true and the elevators positon is < 11
        {
        this.transform.position += new Vector3(0,0,-.2f); //makes elevator move 0.1 in y per frame
        }
    }
    void PlayerCollision()
    {
        CarCrashesIntoPlayer = true;
    }

    void OnEnable()
    {
        EventManagerMain.CrashEvent += PlayerCollision; //adds player crash to crashEvent
    }

    void OnDisable()
    {
        EventManagerMain.CrashEvent -= PlayerCollision;//removes player crash to crashEvent
    }
}
