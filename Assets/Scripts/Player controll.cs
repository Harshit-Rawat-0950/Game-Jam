using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Playercontroll : MonoBehaviour
{
    [SerializeField] Transform leftFootP;
    
    [SerializeField] Transform rightFootP;
    [SerializeField] KeyCode jump;
    [SerializeField] KeyCode MoveRight;
    [SerializeField] KeyCode MoveLeft;
    [SerializeField] KeyCode MoveDown;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float Baseforce;
    [SerializeField] float maxGroundVelocity = 10;
    [SerializeField] float maxAirVelocity = 5;
    [SerializeField] float Drag;
    [SerializeField] float jumpForce;
    [SerializeField] float groundCheckDistance;

    public Vector2 velocity { get; private set; }
    float force;
    public bool isGrounded=true;
    void Update()
    {
        velocity = rb.velocity;
        float xInput = 0;

        xInput = (Input.GetKey(MoveRight)?1:0) - (Input.GetKey(MoveLeft)?1:0);
        isGrounded=checkforground();

        if(isGrounded)
        {
            force=Baseforce*(maxGroundVelocity*xInput-velocity.x);
            if(xInput > 0 && math.abs(rb.velocity[0])<=math.abs(maxGroundVelocity))
            {
                rb.AddForce(Vector2.right*force,ForceMode2D.Force);
            }
            else if (xInput < 0 &&math.abs(rb.velocity[0])<=maxGroundVelocity)
            {
                rb.AddForce(Vector2.right*force,ForceMode2D.Force);
            }
            else
            {
                rb.velocity=new Vector2(rb.velocity[0]/Drag,rb.velocity[1]);
            }
            if(Input.GetKeyDown(jump)){
                rb.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);
                Debug.Log("Jumped");
            }
        }
        else
        {
            
            force=Baseforce*(maxAirVelocity*xInput-velocity.x);
            if(xInput > 0 && math.abs(rb.velocity[0])<=math.abs(maxAirVelocity))
            {
                rb.AddForce(Vector2.right*force,ForceMode2D.Force);
            }
            else if (xInput < 0 &&math.abs(rb.velocity[0])<=maxAirVelocity)
            {
                rb.AddForce(Vector2.right*force,ForceMode2D.Force);
            }
            else
            {
                rb.velocity=new Vector2(rb.velocity[0]/Drag,rb.velocity[1]);
            }
        }
    }
    bool checkforground()
    {
        RaycastHit2D leftFoot = Physics2D.Raycast(leftFootP.position,-transform.up, groundCheckDistance);
        Debug.DrawRay(leftFootP.position,-transform.up*groundCheckDistance);

        RaycastHit2D rightFoot = Physics2D.Raycast(rightFootP.position,-transform.up, groundCheckDistance);
        Debug.DrawRay(rightFootP.position,-transform.up*groundCheckDistance);
        
        if((leftFoot || rightFoot) ) 
        {
            if(leftFoot.collider.tag == "Ground" || leftFoot.collider.tag == "chain" || rightFoot.collider.tag == "Ground" || rightFoot.collider.tag == "chain" )
            {

                // Debug.Log("GG");
                return true;
            }
        }



        return false;
    }


}
