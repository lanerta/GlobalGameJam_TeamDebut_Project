using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeys : MonoBehaviour
{
    public float horizontalI;
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
        else
        {
            jumpKey = false;
        }

        if (Input.GetKey(KeyCode.J))
        {
            glideKey = true;
        }
        else
        {
            glideKey = false;
        }

    }
}
