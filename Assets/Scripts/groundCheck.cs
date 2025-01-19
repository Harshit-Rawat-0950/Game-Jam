using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Playercontroll player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            print("Enter");
            player.isGrounded = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "Ground")
        {
            print("Exit");
            player.isGrounded = false;
        }
    }
}
