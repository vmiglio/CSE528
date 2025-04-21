using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Destroy this collectible
            Destroy(gameObject);
        }
    }
}
