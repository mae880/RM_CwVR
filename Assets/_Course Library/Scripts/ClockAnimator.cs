
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour
{
    private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform hours, minutes, seconds;

    //Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame 
    void Update()
    {
        DateTime time = DateTime.Now;

        seconds.localRotation = Quaternion.Euler(time.Second *
            secondsToDegrees, 0f, 0f);

        TimeSpan timeSpan = DateTime.Now.TimeOfDay;
        hours.localRotation =
            Quaternion.Euler((float)timeSpan.TotalHours * minutesToDegrees,
            0f, 0f);
    }
}
