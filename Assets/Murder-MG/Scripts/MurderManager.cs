using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MurderManager : MonoBehaviour
{
    public List<MovingChar> charList;
    public MovingChar currentChar;

    public MovingChar myMovingChar;

    public TMP_Text textRandomLetter;

    // Start is called before the first frame update
    public void Start()
    {
        charList = new List<MovingChar>();

        CreateMovingChar();     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(charList[0].GetCurrentChar()))
        {
            print("Hello World");
            DestroyMovingObject();
            CreateMovingChar();
        }
        

        /*
        if (charList[0].GameObject.position >= (11.75f, 0f, 0.1f))
        {           
        }
        */

        
        if (charList[0].GetCurrentCoords() >= 11.75f)
        {
            print("Hello World");
            DestroyMovingObject();
            CreateMovingChar();
        }
    }   

    //creating the moving character that the player needs to hit.
    public void CreateMovingChar()
    {
        MovingChar movingChar = new MovingChar();       
        movingChar.SetMovingChar();
               
        currentChar = movingChar;

        textRandomLetter.text = " " + currentChar.GetCurrentChar();

        charList.Add(currentChar);
    }

    public void DestroyMovingObject()
    {
        charList.Clear();
        print("Deleted");
        print(charList.Length);
    }
}
