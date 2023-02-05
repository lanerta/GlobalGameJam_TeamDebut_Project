using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerControllers
{


    public class PlayerMovement : MonoBehaviour
    {
        public float horizontal;
        public float speed = 8f;
        public float jumpingPower = 16f;
        public bool isFacingRight = true;


        [SerializeField] private Rigidbody2D rb;

        [SerializeField] private Transform groundCheck;

        [SerializeField] private LayerMask groundLayer;




        //This function enables to the player to move and jump. The player can hold down the jump button to jump higher.
        void Update()
        {   //The GetAxisRaw function will determine if the player is moving left, right, or standing still.
            horizontal = Input.GetAxisRaw("Horizontal");

            if (Input.GetButtonDown("Jump") && IsGround())
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            }

            if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            }
            //FlipTick is called to constantly check what direction the player is facing.
            FlipTick();
        }

        public void SetHorizontal(float horizontal)
        {
            //-1 or 1
            horizontal = Mathf.Clamp(horizontal, -1, 1);

            this.horizontal = horizontal;
        }

        public void SetRb(Rigidbody2D rb)
        {
            this.rb = rb;
        }
        

        public void SetJumpingPower(float JumpingPower)
        {
            this.jumpingPower = JumpingPower;
        }
        
        

        //This sets the rigid body's velocity equal to the input value times the speed of the player.
        public void FixedUpdate()
        {
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        }

        //This checks if the objected is on the ground. If the OverlapCircle is in contact with the ground layer,
        //the player is able to jump.
        private bool IsGround()
        {
            return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        }

        //This function flips the player when movement direction is changed on the x axis.
        private void FlipTick()
        {
            if (isFacingRight && horizontal < 0f || isFacingRight && horizontal > 0f)
            {
                isFacingRight = !isFacingRight;
                Vector3 localScale = transform.localScale;
                localScale.x *= -1f;
                transform.localScale = localScale;
            }
        }
    }
}

//Blaise Marino
//To set up this code you will have to create a sprite in Unity and apply the code to the Sprite
//You will also need the sprite to have a box collider, sprite renderer, and a rigid body.
//You will need a platform/surface that has the same.