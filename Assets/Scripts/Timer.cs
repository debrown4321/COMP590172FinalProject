using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshPro timerText; // Reference to the UI Text component
    private float startTime; // Time when the scene started
    private bool isRunning = true; // To track if the timer is running
    private static float finalTime;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if (isRunning)
        {
            float elapsedTime = Time.time - startTime; // Calculate elapsed
            string minutes = ((int)elapsedTime / 60).ToString("00");
            string seconds = (elapsedTime % 60).ToString("00");
            timerText.text = minutes + ":" + seconds; // Update the timer text
        }
    }

    public void StopTimer()
    {
        isRunning = false;
        finalTime = Time.time - startTime;
    }

    public static float GetFinalTime()
    {
        return finalTime;
    }
}
