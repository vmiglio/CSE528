using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            
            GameTimer gameTimer = FindObjectOfType<GameTimer>();
            if (gameTimer != null)
            {
                //Save the remaining time to ScoreManager
                ScoreManager.SetFinalTime(gameTimer.GetTimeRemaining());
            }

            //Load the Score scene
            SceneManager.LoadScene("ScoreScreen");


        }
    }
}
