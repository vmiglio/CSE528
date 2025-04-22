using UnityEngine.UI;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    [Header("Timer Settings")]
    [SerializeField] private int startTimeInSeconds = 120; // Set this in the Inspector (e.g., 120 = 2 minutes)

    [Header("UI Reference")]
    [SerializeField] private Text timerText; // Assign your Text UI element here

    private float timeRemaining;
    private bool isRunning = false;

    void Start()
    {
        timeRemaining = startTimeInSeconds;
        isRunning = true;
        UpdateTimerDisplay(); // Show initial time
    }

    void Update()
    {
        if (isRunning && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining < 0)
            {
                timeRemaining = 0;
                isRunning = false;
                // You can add something here like GameOver();
            }
            UpdateTimerDisplay();
        }
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
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
        timeRemaining = startTimeInSeconds;
        UpdateTimerDisplay();
    }
}