using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FanScript : MonoBehaviour
{
    [SerializeField] float airSpeed;
    
    [SerializeField] public float airForce;
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
            playerRB.velocity += new Vector2(0, airSpeed);

        }    
    }
    private void OnTriggerStay2D(Collider2D other) {
        print("Inside Wind");
        if(other.gameObject.tag == "Player")
        {
            Rigidbody2D playerRB = other.gameObject.GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.up*(airForce+10),ForceMode2D.Force);

        }    
    }

    // Update is called once per frame
    public void setAirforce()
    {
        airForce=12;
    }
    void Update()
    {
        
    }
}
