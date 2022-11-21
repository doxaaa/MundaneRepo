using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashTrigger : MonoBehaviour
{

    // Start is called before the first frame update
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
