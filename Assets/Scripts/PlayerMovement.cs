using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // Left/Right arrows or A/D
        float moveY = Input.GetAxisRaw("Vertical");   // Up/Down arrows or W/S

        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;
        transform.position += (Vector3)(moveDirection * speed * Time.deltaTime);
    }
}
