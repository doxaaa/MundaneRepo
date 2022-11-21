using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardReader : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider collisionObject)
    {
        if (collisionObject.name == "Card")
        {
            EventManagerMain.RunCardSwipe();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
