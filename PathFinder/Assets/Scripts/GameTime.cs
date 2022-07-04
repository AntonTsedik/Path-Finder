using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameTime : MonoBehaviour
{
    private Text CounterText;
    private float startSeconds;
    private bool stopWatchActive = false;

    private void Start()
    {
        startSeconds = 0;
        CounterText = GetComponent<Text>() as Text;
    }
    private void Update()
    {
        if (stopWatchActive == true)
        {
            startSeconds = startSeconds + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(startSeconds);
        CounterText.text = time.Seconds.ToString();
    }
    public void StartStopwatch()
    {
        stopWatchActive = true;
    }
    public void StopStopwatch()
    {
        stopWatchActive = false;
    }
}
