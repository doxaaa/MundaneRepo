using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardReader : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Transition;
    void OnTriggerEnter(Collider collisionObject)
    {

        if (collisionObject.name == "Card")
        {
            EventManagerMain.RunCardSwipe();

            LevelNext();
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
