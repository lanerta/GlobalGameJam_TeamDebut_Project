using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KassiePlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;

    private Rigidbody2D _rigidbody2d;
    private SpriteRenderer _spriteRenderer;
    private bool isFacingLeft;
    [SerializeField] private Sprite upSprite;
    [SerializeField] private Sprite downSprite;

    private float moveX;
    
    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        moveX = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (moveX > 0)
        {
            isFacingLeft = false;
        }
        if (moveX < 0)
        {
            isFacingLeft = true;
        }
        _spriteRenderer.flipX = isFacingLeft;

        if (_rigidbody2d.velocity.y >= 0)
        {
            _spriteRenderer.sprite = upSprite;
        }
        else
        {
            _spriteRenderer.sprite = downSprite;
            
        }
    }

    
    private void FixedUpdate()
    {
        Vector2 velocity = _rigidbody2d.velocity;
        velocity.x = moveX;
        _rigidbody2d.velocity = velocity;
    }
}
