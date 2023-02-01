using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeys : MonoBehaviour
{
    public float horizontalI = 0;
    public bool jumpKey;
    public bool glideKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalI = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.K))
        {
            jumpKey = true;
        }

        if (Input.GetKey(KeyCode.J))
        {
            glideKey = true;
        }

    }
}
