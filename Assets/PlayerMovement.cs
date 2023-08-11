using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    
    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float left = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(left * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 7f);
        }
    }

   
}
