using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Timer : SingletonMonoBehavior<Timer>
{
    float StartTime;
    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.time;
    }


    public string GetTimeString()
    {
        float TotalTime = Time.time - StartTime;
        TimeSpan time = TimeSpan.FromSeconds(TotalTime);
        print("Time : " + time.ToString("hh':'mm':'ss"));
        return "Time : " + time.ToString("hh':'mm':'ss");
    }
}
