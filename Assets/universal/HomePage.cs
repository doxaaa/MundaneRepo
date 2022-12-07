using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HomePage : MonoBehaviour
{


    public Animator Transition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnHome()
    {
        LevelNext();
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
        SceneManager.LoadScene(0);
    }




    public void Restart()
    {
        Retry();
    }


    public void Retry()
    {
        Transition.SetTrigger("Start");

        StartCoroutine(RetryLevel());
    }
    // Function to load the next level
    IEnumerator RetryLevel()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
