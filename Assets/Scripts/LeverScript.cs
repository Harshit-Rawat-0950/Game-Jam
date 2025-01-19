using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    [SerializeField] Door dr;
    Animator anim;
    [SerializeField] Collider2D lever;
    public bool deactivated=true;
    float count=0.2f;

    void Start()
    {
        anim.SetBool("idle_deactivated",true);
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision other)
    {

        // if(other.tag=="Player"&&deactivated)
        // {
            Debug.Log("player hit");
            leverpulled();
            // deactivated=false;
        // }
        // Debug.Log("Hit");
    }
    void Update(){
        // count+=Time.deltaTime;
        if(deactivated)
        {   
            // anim.SetBool("lever_animation",false);
        }
        if(count>0.2f&&!deactivated){
        // anim.SetBool("idle_acticated",true);
        // anim.SetBool("lever_animation",false);
        }
    }
    void leverpulled()
    {
        Debug.Log("asdf");
        // anim.SetBool("lever_animation",true);
        // anim.SetBool("idle_deactivated",false);
        count=0f;
        dr.move();
    }
}
