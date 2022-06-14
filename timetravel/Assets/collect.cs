using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
   bool iscollected = false;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        iscollected = true;  
        Destroy(gameObject);
        
    }
    void update() 
    {
        if (iscollected) 
        {
            print("gecolecteerd");
        }
    }
}
