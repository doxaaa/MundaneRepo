using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProtoLevelLoader : MonoBehaviour
{
    public GameObject victoryObject;
    public GameObject loserObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //Active lose state thing
     public void levelLost() {
        loserObject.SetActive(true);
        StartCoroutine(Restart());
    }
    // Function to restart the game
    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    //Activate victory thing
    public void levelWon()
    {
        victoryObject.SetActive(true);
        StartCoroutine(LoadNextLevel());
    }
    // Function to load the next level
    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
