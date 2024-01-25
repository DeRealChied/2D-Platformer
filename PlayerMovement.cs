using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 7f;
    // the empty GameObect that's a child of the player, at his feet. The circle will be drawn from here
    [SerializeField] private Transform groundCheckPoint;
    //The layer the ground and platforms are one. The circle will only check this
    [SerializeField] private LayerMask platformerLayer;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        // creates a circle at that point, of that size, that checks for anything on that layer
        bool isOnGround = Physics2D.OverlapCircle(groundCheckPoint.position, 0.05f, platformerLayer);
        bool spacePressed = Input.GetKeyDown(KeyCode.Space);
        if (isOnGround && spacePressed)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.Play("Player.Jump");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sprite.flipX = true;
            anim.Play("Player.Run");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            sprite.flipX = false;
            anim.Play("Player.Run");
        }
        else
        {
            anim.Play("Player.Idle");
        }
    }
    float dir = 1;
    private void FixedUpdate()
    {
        // -1, 0, 1, depending on the arrow keys pressed
        float direction = Input.GetAxisRaw("Horizontal");
        // set the x-axis movement to -1, 0, 1 by speed, set the y-axis to whatever it is (i.e. leave it unchanged)
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
    }
}
