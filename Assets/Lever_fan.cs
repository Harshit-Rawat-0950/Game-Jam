using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lever_fan : MonoBehaviour
{
    [SerializeField] FanScript fanScript;
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
   
        if(deactivated&&other.tag=="Player"){
            audiomanager.lever();
            fanScript.setAirforce();
            anim.SetBool("Moving",true);
            deactivated=false;
            }
    }
}
