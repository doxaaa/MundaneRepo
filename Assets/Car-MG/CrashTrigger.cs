using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashTrigger : MonoBehaviour
{

    // Start is called before the first frame update


    public Animator Transition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider CollisionData) 
    {
            if(CollisionData.name == "Player")
        {
            print("Car Crash");

            EventManagerMain.CrashFunction();
            levelLost();

        }
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
