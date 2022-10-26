using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockIn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SuccessfulSwipe()
    {
        //this.GetComponent<AudioSource>().Play();
        print("you have clocked in");
    }

    private void OnEnable()
    {
        ClockInEventManager.ClockIn += SuccessfulSwipe;
    }

    private void OnDisable()
    {
        ClockInEventManager.ClockIn -= SuccessfulSwipe;
    }
}
