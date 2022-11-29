using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinCheck : MonoBehaviour
{
    private int clothingCount = 0;
    public Animator Transition;
    private void clothesPutOn()
    {
        clothingCount = clothingCount + 1;
        print(clothingCount);
    }

    void FixedUpdate()
    {
        if(clothingCount == 4)
        {
            LevelNext();
        }
    }

    void OnEnable()
    {
        EventManagerMain.DressingWinEvent += clothesPutOn;
    }
        void OnDisable()
    {
        EventManagerMain.DressingWinEvent -= clothesPutOn;
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
