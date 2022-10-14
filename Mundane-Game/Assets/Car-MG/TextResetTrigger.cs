using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextResetTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text resetText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void ResetTMPObject()
    {
        resetText.text = "";
    }
    void OnEnable()
    {
        EventManager.ResetEvent += ResetTMPObject; //adds player crash to crashEvent
    }

    void OnDisable()
    {
        EventManager.ResetEvent -= ResetTMPObject;//removes player crash to crashEvent
    }
}
    

