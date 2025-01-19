using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FanScript : MonoBehaviour
{
    [SerializeField] float airSpeed;
    [SerializeField] AudioManager audiomanager;
    
    [SerializeField] public float airForce;
    ParticleSystem particleSystem;
    public bool stop;
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        if(stop) particleSystem.Stop();  
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
            audiomanager.wind();
        }    
    }
    private void OnTriggerStay2D(Collider2D other) {

        if(other.gameObject.tag == "Player")
        {
            Rigidbody2D playerRB = other.gameObject.GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.up*(airForce+10),ForceMode2D.Force);

        }    
    }
    private void OnTriggerExit2D()
    {
        audiomanager.stop();
    }

    // Update is called once per frame
    public void setAirforce()
    {
        airForce=12;
        particleSystem.Play();
    }
    void Update()
    {
        
    }
}
