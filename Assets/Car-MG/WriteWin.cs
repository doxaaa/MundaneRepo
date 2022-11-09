using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WriteWin : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text winText;
    void Start()
    {
        
    }

    // Update is called once per frame
   void WriteWinText()
    {
        winText.text = "You Win.";
    }
    void OnEnable()
    {
        EventManagerMain.WinEvent += WriteWinText; //adds player crash to crashEvent
    }

    void OnDisable()
    {
        EventManagerMain.WinEvent -= WriteWinText;//removes player crash to crashEvent
    }
}
