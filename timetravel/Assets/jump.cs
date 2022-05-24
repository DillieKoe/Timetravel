using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float buttonTime = 0.3f;
    public float jumpAmount = 20;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;
    float jumpTime;
    bool jumping;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            jumping = true;
            jumpTime = 00;
        }
        if(jumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpAmount);
            jumpTime += Time.deltaTime;
        }   
            if(rb.velocity.y >= 1)
        {
            rb.gravityScale = gravityScale;
        }
        else if (rb.velocity.y < 1)
        {
            rb.gravityScale = fallingGravityScale;
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            jumping = false;
        }
    }
}
