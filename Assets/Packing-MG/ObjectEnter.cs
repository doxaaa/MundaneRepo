using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObjectEnter : MonoBehaviour
{
    // Start is called before the first frame update
    private int packageCount;

    public Animator Transition;
    void Start()
    {
        packageCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(packageCount >= 10)
        {
            LevelNext();
        }
    }
    void OnTriggerEnter(Collider CollisionData) 
    {
        print("event played");
        EventManagerMain.PackageFunction();
        packageCount = packageCount + 1;
        print(packageCount);

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
