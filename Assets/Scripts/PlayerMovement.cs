using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    //Set this value so that it can be reset after speed up
    private float originalSpeed;

    //[Header("Character Sprites")]
    //public Sprite boySprite;
    //public Sprite girlSprite;

    private SpriteRenderer spriteRenderer;

    private Animator animator;

    private bool isMoving;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        originalSpeed = speed;

        ////Set the correct character sprite
        //if (CharacterSelector.selectedCharacter == 0)
        //{
        //    spriteRenderer.sprite = boySprite;
        //}
        //else
        //{
        //    spriteRenderer.sprite = girlSprite;
        //}
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // Left/Right arrows or A/D
        float moveY = Input.GetAxisRaw("Vertical");   // Up/Down arrows or W/S

        if (moveX != 0 || moveY != 0 )
        {
            isMoving = true;

            animator.SetFloat("moveX", moveX);
            animator.SetFloat("moveY", moveY);

            Vector2 moveDirection = new Vector2(moveX, moveY).normalized;
            transform.position += (Vector3)(moveDirection * speed * Time.deltaTime);

        }
        else
        {
            //Player is not moving
            isMoving = false;
        }

        //Set the "isMoving" parameter to transition between idle and walk blend trees
        animator.SetBool("isMoving", isMoving);

    }

    public void BoostSpeed(float newSpeed, float duration)
    {
        //Stop any previous boost timers
        StopAllCoroutines(); 
        StartCoroutine(SpeedBoostCoroutine(newSpeed, duration));
    }

    private IEnumerator SpeedBoostCoroutine(float newSpeed, float duration)
    {
        speed = newSpeed;
        yield return new WaitForSeconds(duration);
        speed = originalSpeed;
    }

}
