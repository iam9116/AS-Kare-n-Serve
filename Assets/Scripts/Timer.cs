using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float startTime = 60f; // Set the countdown time in seconds
    private float timeRemaining;
    private bool isRunning = false;

    void Start()
    {
        timeRemaining = startTime;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerText(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                isRunning = false;
                // Optionally, trigger an event when the timer reaches zero
                TimerEnded();
                SceneManager.LoadScene(4);
            }
        }
    }

    void UpdateTimerText(float time)
    {
        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
    }

    void TimerEnded()
    {
        // Code to execute when the timer ends
        Debug.Log("Timer has ended!");
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        timeRemaining = startTime;
        isRunning = true;
    }
}
