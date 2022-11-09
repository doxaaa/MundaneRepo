using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingChar : MonoBehaviour
{
    public string currentChar;
    //Created to track the location of the Cube
    public float currentCoords; 
    public GameObject Cube;
    int currentSpeed;
    bool moveCube;

    public void SetMovingChar()
    {
        CharStats();
        MovingCube();
    }

    public void CharStats()
    {
        //creating the parameters that will define the variables
        string alphabet = ("abcdefghijklmnopqrstuvwxyz1234567890");
        int randomNumber = Random.Range(0, 35);
        char randomChar = (alphabet[randomNumber]);

        //assigning the results to the variables
        currentChar = randomChar.ToString();              
    }

    public void MovingCube()
    {
        //create the Cube here, create the movement and then apply 'currentSpeed' to it.
        Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Cube.transform.position = new Vector3(-10f, 60f, -0.1f);
        currentCoords = -10f;
        moveCube = true;
        FixedUpdate();
    }

    void FixedUpdate()
    {  
        
    }

    public string GetCurrentChar()
    {
        return currentChar;
    }

    public float GetCurrentCoords()
    {
        return currentCoords;
    }

    public void DestroyCube()
    {
        Destroy(Cube);
        currentCoords = -10f;
        moveCube = false;
    }
}
