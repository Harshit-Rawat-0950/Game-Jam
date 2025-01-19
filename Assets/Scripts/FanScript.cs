using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanScript : MonoBehaviour
{
    [SerializeField] float airSpeed;
    Rigidbody2D rb;
    void Start()
    {
        
    }
    void onCollisionEnter(Collision collision)    
    {
        if(collision.gameObject.tag=="Player"){
            rb=collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity=new Vector2(rb.velocity[0],airSpeed);
            Debug.Log("In wind");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
