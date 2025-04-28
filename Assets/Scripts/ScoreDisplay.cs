using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    void Start()
    {
        int minutes = Mathf.FloorToInt(ScoreManager.finalTime / 60);
        int seconds = Mathf.FloorToInt(ScoreManager.finalTime % 60);
        scoreText.text = $"Time Left: {minutes:00}:{seconds:00}";
    }
}
