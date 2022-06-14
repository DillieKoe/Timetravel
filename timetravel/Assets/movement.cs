using System.Collections;
using UnityEngine;
using System;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 20;
    public bool grounded;
    public float jumpTime =1;
    public float jumpTimeCounter;
    public float jumpForce = 50;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;
    public float boost = 10;
    GameObject cload;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        //jumpTimeCounter = jumpTime;
        
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Output the Collider's GameObject's name
        print(collision.collider.name);

        if(collision.collider.name == "bounce") {
            bouncyBlock();
        }
         if(collision.collider.name == "death") {
            death();
        }
          if(collision.collider.name == "lava") {
           death();
        }
          if(collision.collider.name == "nojumpzone") {
           grounded = false;
        }
         if(collision.collider.name == "diamand") {
           print("je hebt een diamand gevonden");
         
            
        }
         if(collision.collider.name == "portal 1") {
           transform.position = new Vector3(210,10,2);
            
        }
          if(collision.collider.name == "portal 2") {
            transform.position = new Vector3(190, 2, 2);
            
        }
        if(collision.collider.name == "portal 3") {
            transform.position = new Vector3(190, 2, 2);
            
        }
        if(collision.collider.name == "portal 4") {
            transform.position = new Vector3(200, 13, 2);
            
        }
        if(collision.collider.name == "portal 5") {
         transform.position = new Vector3(190, 2, 2);
            
        }
        if(collision.collider.name == "button") {
         buttonactivate1();
        }
        if(collision.collider.name == "boostpad") {
        rb.gravityScale =-1;
        }

        if(collision.collider.name == "-boostpad") {
        rb.gravityScale =20;
        }
        
    }

    void bouncyBlock(){
        }
    void buttonactivate1(){
         rb.velocity = new Vector2 (rb.velocity.x, 150);
        }
    
    void death(){
       transform.position = new Vector3(-65, 2, 0);
        print("you died");
    }
    
   

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
       
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
           
       }

         if (Input.GetKey(KeyCode.LeftShift))
       {
           speed = 40;      
       }
       else 
       {
          speed = 20;
       }

        if (Input.GetKey(KeyCode.W))
        {
            System.Console.WriteLine("3");
            if(jumpTimeCounter > 0)
            {
                // keep jumping!
                rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
                jumpTimeCounter = jumpTimeCounter - Time.deltaTime;
            
            }
                
        }
        
    
        if (Input.GetKey(KeyCode.W) && grounded)
        {
            
            rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
            jumpTimeCounter = jumpTime;
                
        }
        
        if(Input.GetKeyUp(KeyCode.W))
        {
            jumpTimeCounter = 0;
        }
        
           if(!grounded) {
              Instantiate (cload, transform.position, cload.transform.rotation);
           }else{
               print("666");
           }
           
        
       
    }

        
}