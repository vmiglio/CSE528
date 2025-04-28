using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float bonusTime = 30f;
    public float speedBoostAmount = 8f; 
    public float boostDuration = 15f; 

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object has the tag "Player"
        if (other.CompareTag("Player"))
        {

            GameTimer timer = FindObjectOfType<GameTimer>();

            if (timer != null)
            {
                timer.AddTime(bonusTime);
            }

            //Boost player speed
            PlayerMovement player = other.GetComponent<PlayerMovement>();

            if (player != null)
            {
                player.BoostSpeed(speedBoostAmount, boostDuration);
            }


            Destroy(gameObject);
        }
    }
}
