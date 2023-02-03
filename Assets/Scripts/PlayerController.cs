using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 4f;
    public bool isGrounded = false;
    private Rigidbody2D _rigidbody2D;
    private PlayerKeys _playerKeys;
    public bool isInAir = false;
    public int jumpThrust = 2;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerKeys = GetComponent<PlayerKeys>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // Add Force to Rigidbody2D for Jump
        if ((_playerKeys.jumpKey == true) && (isGrounded == true))
        {
            _rigidbody2D.AddForce(transform.up * jumpThrust, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(_playerKeys.horizontalI * moveSpeed * Time.deltaTime, 0, 0);
        // Change Gravity When Gliding
        if ((_playerKeys.glideKey == true) && (_rigidbody2D.velocity.y < 0))
        {
            _rigidbody2D.gravityScale = 0.5f;
        }
        else
        {
            _rigidbody2D.gravityScale = 1f;
        }


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = false;
        }
    }
}
