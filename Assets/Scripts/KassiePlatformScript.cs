using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KassiePlatformScript : MonoBehaviour
{
    public float jumpForce = 10f;
    [SerializeField] private AudioSource jumpSoundEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            jumpSoundEffect.Play();
            Rigidbody2D _rigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            if (_rigidbody != null)
            {
                Vector2 velocity = _rigidbody.velocity;
                velocity.y = jumpForce;
                _rigidbody.velocity = velocity;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
