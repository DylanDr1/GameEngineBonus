using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
  
    public static Timer Instance { get; private set; }

 
    [SerializeField] private TextMeshProUGUI timeText;

 
    private float elapsedTime;
    private bool isRunning;

   

    private void Start()
    {
        StartTimer();
    }

    private void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimeDisplay();
        }
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        elapsedTime = 0;
        UpdateTimeDisplay();
    }

    private void UpdateTimeDisplay()
    {
      
        int minutes = Mathf.FloorToInt(elapsedTime / 60F);
        int seconds = Mathf.FloorToInt(elapsedTime % 60F);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

