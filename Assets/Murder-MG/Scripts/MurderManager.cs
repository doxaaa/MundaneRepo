using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MurderManager : MonoBehaviour
{
    public List<MovingChar> charList;
    public MovingChar currentChar;

    public MovingChar myMovingChar;
    public Player myPlayer;

    public TMP_Text murderText;
    
    public int playerLocation = 0;
    bool gameOver = false;

    // Start is called before the first frame update
    public void Start()
    {
        charList = new List<MovingChar>();
        CreateMovingChar();     
    }

    // Update is called once per frame
    void Update()
    {
        //A test for the location condition
        //if (charList.[0].Cube.xposition > (-3.075f, 59.8f, -1.08f) && charList.[0].Cube.position <(1.05f, 59.8, -1.08f))

        if(gameOver == false)
        {
            if (charList[0].GetCurrentCoords() > -3.075f && charList[0].GetCurrentCoords() < 1.05f)
            {
                if (Input.GetKeyDown(charList[0].GetCurrentChar()))
                {
                    print("Hello World");
                    DestroyMovingObject();
                    CreateMovingChar();
                    EventManagerMain.RunMovePlayerEvent();
                    playerLocation += 2;
                }
            }
        }

        /*
        if (charList[0].GameObject.position >= (11.75f, 0f, 0.1f))
        {           
        }
        */

        if (gameOver == false)
        {
            if (charList[0].GetCurrentCoords() >= 2f)
            {
                print("Hello World");
                DestroyMovingObject();
                CreateMovingChar();
            }
        }

        if(playerLocation == 16)
        {
            murderText.text = "CoWorker Killed";
            gameOver = true;
        }
    }   

    //creating the moving character that the player needs to hit.
    public void CreateMovingChar()
    {
        MovingChar movingChar = new MovingChar();       
        movingChar.SetMovingChar();
               
        currentChar = movingChar;

        murderText.text = " " + currentChar.GetCurrentChar();

        charList.Add(currentChar);
        print(charList.Count);
    }

    public void DestroyMovingObject()
    {
        charList[0].DestroyCube();
        charList.Clear();
        print("Deleted");
        print(charList.Count);
    }

    void FixedUpdate()
    {
        if (gameOver == false)
        {
            charList[0].Cube.transform.position += new Vector3(0.1f, 0f, 0f);
            charList[0].currentCoords += 0.1f;
        }
    }
}
