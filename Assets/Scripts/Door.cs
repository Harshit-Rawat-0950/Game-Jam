using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] Transform targetLocation;
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void move()
    {
        rb.transform.position=targetLocation.position;
        rb.velocity=new Vector2(0,0);
    }
}
