using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 4f;
    public bool isGrounded = true;
    private Rigidbody2D _rigidbody2D;
    private PlayerKeys _playerKeys;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerKeys = GetComponent<PlayerKeys>();
    }

    // Update is called once per frame
    void Update()
    {
        // Change Gravity When Gliding
        if (_playerKeys.glideKey == true)
        {
            _rigidbody2D.gravityScale = 0.5f;
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
        isGrounded = false;
    }
}
