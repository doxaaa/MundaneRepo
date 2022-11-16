using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClockInEvent : MonoBehaviour
{
    public void SuccessfulSwipe()
    {
        //this.GetComponent<AudioSource>().Play();
        print("you have clocked in");
    }

    private void OnEnable()
    {
        EventManagerMain.ClockIn += SuccessfulSwipe;
    }

    private void OnDisable()
    {
        EventManagerMain.ClockIn -= SuccessfulSwipe;
    }
}
