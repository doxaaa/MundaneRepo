using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator Transition;

    public void startGame()
    {
        LevelStart();
    }

    public void quitGame()
    {
        Debug.Log("This would quit the game if fully built");
        Application.Quit();
    }



    //Activate victory thing
    public void LevelStart()
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
