using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingChar : MonoBehaviour
{
    public string currentChar;
    //Created to track the location of the Cube
    public float currentCoords = -10f;
    public GameObject cube;
    int currentSpeed;

    public bool moveCube = false;

    public void SetMovingChar()
    {
        CharStats();
        MovingCube();
    }

    public void CharStats()
    {
        //creating the parameters that will define the variables
        string alphabet = ("abcdefghijklmnopqrstuvwxyz1234567890");
        int randomNumber = Random.Range(0, 63);
        char randomChar = (alphabet[randomNumber]);

        //assigning the results to the variables
        currentChar = randomChar.ToString();              
    }

    public void MovingCube()
    {
        //create the Cube here, create the movement and then apply 'currentSpeed' to it.
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(currentCoords, 60f, -0.1f);
        moveCube = true;
    }

    void FixedUpdate()
    {
        if (moveCube == true)
        {
            cube.transform.position += new Vector3(0.1f, 0f, 0f);
            currentCoords += 0.2f;
            moveCube = false;
        }
    }

    public string GetCurrentChar()
    {
        return currentChar;
    }

    public float GetCurrentCoords()
    {
        return currentCoords;
    }
}
