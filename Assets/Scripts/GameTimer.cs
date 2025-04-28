using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTimer : MonoBehaviour
{

    [Header("Timer Settings")]
    [SerializeField] private int startTimeInSeconds = 120;

    [Header("UI Reference")]
    [SerializeField] private Text timerText; 

    private float timeRemaining;
    private bool isRunning = false;

    void Start()
    {
        timeRemaining = startTimeInSeconds;
        isRunning = true;
        UpdateTimerDisplay(); 
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

                SceneManager.LoadScene("GameOver");
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

    public void AddTime(float amount)
    {
        timeRemaining += amount;
        UpdateTimerDisplay();
    }

    public float GetTimeRemaining()
    {
        return timeRemaining;
    }
}