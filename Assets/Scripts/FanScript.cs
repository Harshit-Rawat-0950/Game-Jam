using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FanScript : MonoBehaviour
{
    [SerializeField] float airSpeed;
    void Start()
    {
        
    }
    // void onCollisionEnter(Collision collision)    
    // {
    //     if(collision.gameObject.tag=="Player"){
    //         rb=collision.gameObject.GetComponent<Rigidbody2D>();
    //         rb.velocity=new Vector2(rb.velocity[0],airSpeed);
    //         Debug.Log("In wind");
    //     }
    // }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            Rigidbody2D playerRB = other.gameObject.GetComponent<Rigidbody2D>();
            playerRB.velocity += new Vector2(0, 10);

        }    
    }
    private void OnTriggerStay2D(Collider2D other) {
        print("Inside Wind");
        if(other.gameObject.tag == "Player")
        {
            Rigidbody2D playerRB = other.gameObject.GetComponent<Rigidbody2D>();
            playerRB.velocity += new Vector2(0, 10);

        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
