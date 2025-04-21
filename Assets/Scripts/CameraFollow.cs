using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Assign your player GameObject in the Inspector
    private Vector3 offset;

    void Start()
    {
        // Calculate the initial offset from player to camera
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // Directly set camera position to follow the player with the offset
        transform.position = player.position + offset;
    }
}
