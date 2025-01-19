using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    [SerializeField] Door dr;
    [SerializeField] AudioManager audiomanager;
    Animator anim;
    public bool deactivated=true;
    float count=0.2f;
    void Start(){
        anim=GetComponent<Animator>();
    }
    void Update(){
        anim.SetBool("Activated",!deactivated);
    }
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Enter");
        if(deactivated&&other.tag=="Player"){
            audiomanager.lever();
            dr.move();
            anim.SetBool("Moving",true);
            deactivated=false;
            Debug.Log(deactivated);
            
            }
    }
}
