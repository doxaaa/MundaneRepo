using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinChecker : MonoBehaviour
{
    private int itemCountCheck = 0; 
    public Animator Transition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(itemCountCheck == 4)
        {
            LevelNext();
        }
    }

    private void AddToCount()
    {
        itemCountCheck = itemCountCheck + 1;
    }

    private void OnEnable()
    {
        EventManagerMain.BuildObject += AddToCount;
    }

    private void OnDisable()
    {
        EventManagerMain.BuildObject -= AddToCount;
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
