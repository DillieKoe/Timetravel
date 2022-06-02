using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 20;
    public bool grounded;
    public float jumpTime;
    public float jumpTimeCounter;
    public float jumpForce = 50;
    public bool stoppedJumping;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;
 
    void Start()
    
    {
        rb = GetComponent<Rigidbody2D>();  
        jumpTimeCounter = jumpTime;
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
       if (Input.GetKey(KeyCode.D))
       {
           rb.velocity = new Vector2(speed, rb.velocity.y);
       }
        else if (Input.GetKey(KeyCode.A))
       {
           rb.velocity = new Vector2(-speed, rb.velocity.y);
           
       }
       else 
       {
           rb.velocity = new Vector2(0, rb.velocity.y);
           rb.gravityScale =0; 
       }

        if (Input.GetKey(KeyCode.S))
       {
            rb.gravityScale =100; 
       }
       else {
           rb.gravityScale =20;
       }
         if (Input.GetKey(KeyCode.LeftShift))
       {
           speed = 40;         
       }
       else 
       {
          speed = 20;
       }
      
       if(grounded)
        {
            //the jumpcounter is whatever we set jumptime to in the editor.
            jumpTimeCounter = jumpTime;
        }
        
    
        if (Input.GetKey(KeyCode.W))
       {
           if(grounded){
                rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
                stoppedJumping = false;
           }
       }
    
        if (Input.GetKey(KeyCode.W) && !stoppedJumping)
        {
            //and your counter hasn't reached zero...
            if(jumpTimeCounter > 0)
            {
                //keep jumping!
                rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        }
        
        if(Input.GetKeyUp(KeyCode.W))
        {
            //stop jumping and set your counter to zero.  The timer will reset once we touch the ground again in the update function.
            jumpTimeCounter = 0;
            stoppedJumping = true;
        }
        
    }
}