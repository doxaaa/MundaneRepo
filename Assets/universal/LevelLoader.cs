using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update

    public float transitionTime = 1f;
    public bool CheckForWinState = false;
    public Animator transition;

    void Start()
    {
        CheckForWinState = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(CheckForWinState == true)
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    void PlayTransition()
    {
        CheckForWinState = true;
    }

    void OnEnabled() 
    {
        EventManagerMain.LoadSceneEvent += PlayTransition;
    }
    void OnDisable() 
    {
        EventManagerMain.LoadSceneEvent -= PlayTransition;
    }
}
