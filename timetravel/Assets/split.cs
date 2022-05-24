using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class split : MonoBehaviour
{
  Rigidbody2D rb;
    float horizontal;
    float vertical;
    public float RotateSpeed = 1f;
    public float gravityScale = 10;
    public float runSpeed = 10.0f;
    public float fallingspeed = 10.0f;
    bool isfalling = false;
    bool onground = false;
   
 void Awake()
    {
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();  
        
    }

    // Update is called once per frame
    void Update()
    {
      movement(); 
      fall();

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

  private void movement()
    {
        rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);  
        rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);  
    }
  private void fall()
    {
      if(onground){
      rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
      }
      if(isfalling == true){
        
        

      }
      if (rb.velocity.y > -2)
      isfalling = true;
       else {
         isfalling = false;
         rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);  
       }      
      


     
    }
}
