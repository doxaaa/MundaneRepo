using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MurderManager : MonoBehaviour
{
    public List<MovingChar> charList;
    public MovingChar currentChar;

    public MovingChar myMovingChar;
    public player myPlayer;

    public TMP_Text murderText;
    
    public int playerLocation = 0;
    bool gameOver = false;

    public Animator Transition;
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
                DestroyMovingObject();
                CreateMovingChar();
            }
        }

        if(playerLocation == 16)
        {
            murderText.text = "CoWorker Killed";
            gameOver = true;
            LevelNext();

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





    public void LevelNext()
    {
        Transition.SetTrigger("Start");

        StartCoroutine(LoadNextLevel());
    }
    // Function to load the next level
    IEnumerator LoadNextLevel()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
