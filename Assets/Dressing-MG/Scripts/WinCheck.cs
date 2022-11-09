using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinCheck : MonoBehaviour
{
    private int clothingCount = 0;

    private void clothesPutOn()
    {
        clothingCount = clothingCount + 1;
        print(clothingCount);
    }

    void FixedUpdate()
    {
        if(clothingCount == 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

}
