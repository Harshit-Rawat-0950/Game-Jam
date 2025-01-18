using System;
using System.Collections;
using System.Collections.Generic;
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
    [SerializeField] float maxVelocity;
    [SerializeField] float Drag;
    [SerializeField] float jumpForce;
    [SerializeField] float groundCheckDistance;
    float force;
    public bool isGrounded=true;
    public bool rightFootHit;
    public bool leftFootHit;
    void Update()
    {
        force=Baseforce*(maxVelocity-rb.velocity[0]-1);
        if(Input.GetKey(MoveRight)&&isGrounded&&math.abs(rb.velocity[0])<=math.abs(maxVelocity))
        {
            rb.AddForce(Vector2.right*force,ForceMode2D.Force);
        }
        if(Input.GetKeyUp(MoveRight)&&isGrounded)rb.AddForce(Vector2.left*Baseforce,ForceMode2D.Force);
        if(Input.GetKey(MoveLeft)&&isGrounded&&math.abs(rb.velocity[0])<=maxVelocity)
        {
            rb.AddForce(Vector2.left*force,ForceMode2D.Force);
        }
        if(Input.GetKeyUp(MoveRight)&&isGrounded)rb.AddForce(Vector2.left*Baseforce,ForceMode2D.Force);
        else if(isGrounded)rb.velocity=new Vector2(rb.velocity[0]/Drag,rb.velocity[1]);
        if(Input.GetKeyDown(jump)&&isGrounded){
            rb.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);
        }
        isGrounded=checkforground();
    }
    bool checkforground()
    {
        RaycastHit2D leftFoot = Physics2D.Raycast(leftFootP.position,-transform.up*groundCheckDistance);
        RaycastHit2D righFoot = Physics2D.Raycast(rightFootP.position,-transform.up*groundCheckDistance);
        Debug.DrawRay(leftFootP.position,-transform.up*groundCheckDistance);
        Debug.DrawRay(rightFootP.position,-transform.up*groundCheckDistance);
        if(leftFoot&&leftFoot.collider.tag=="Ground"||righFoot&&righFoot.collider.tag=="Ground")
        {
            Debug.Log("GG");
            return true;
        }
        else return false;

    }
}
