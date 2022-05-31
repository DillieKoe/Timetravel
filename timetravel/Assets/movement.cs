using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 20;
   
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  

          
    }

    // Update is called once per frame
    void Update()
    {
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
            rb.gravityScale =1000; 
       }
       else if (Input.GetKey(KeyCode.W))
       {
           rb.gravityScale =1; 
           
       }
       else 
       {
           
           rb.gravityScale =20;
       }
    }
}