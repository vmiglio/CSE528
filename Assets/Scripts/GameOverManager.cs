using System.Diagnostics;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioClip gameOverSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null && gameOverSound != null)
        {
            audioSource.PlayOneShot(gameOverSound);
        }
    }
}
