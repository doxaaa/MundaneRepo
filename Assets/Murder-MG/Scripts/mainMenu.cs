using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    public MurderManager myMurderManager;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Destroy(gameObject);
            myMurderManager.Start();
        }
    }
}
