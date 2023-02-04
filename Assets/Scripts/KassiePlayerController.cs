using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KassiePlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;

    public Rigidbody2D _rigidbody2d;

    private float moveX;
    
    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = _rigidbody2d.velocity;
        velocity.x = moveX;
        _rigidbody2d.velocity = velocity;
    }
}
