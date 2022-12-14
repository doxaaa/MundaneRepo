using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TestCountdown : MonoBehaviour

{
    public float timeRemaining = 30;
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    public Animator Transition;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;

            if (timeRemaining == 0 && timerIsRunning == false)
                {
                    levelLost();
                }
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }





    public void levelLost()
    {
        Transition.SetTrigger("Start");
        StartCoroutine(Restart());
    }
    // Function to restart the game
    IEnumerator Restart()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Fail");
    }
}
