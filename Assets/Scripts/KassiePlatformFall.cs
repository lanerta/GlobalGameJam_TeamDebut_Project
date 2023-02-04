using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KassiePlatformFall : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Invoke("DropPlatform", 0.5f);
            Destroy(gameObject, 2f);
        }
    }

    void DropPlatform()
    {
        _rigidbody2D.isKinematic = false;
    }
}
