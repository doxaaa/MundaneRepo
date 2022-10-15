using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WriteToTMPObject : MonoBehaviour
{
    public TMP_Text crashText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void WriteDeathText()
    {
        crashText.text = "You Died.";
    }
    void OnEnable()
    {
        EventManager2.CrashEvent += WriteDeathText; //adds player crash to crashEvent
    }

    void OnDisable()
    {
        EventManager2.CrashEvent -= WriteDeathText;//removes player crash to crashEvent
    }
}
