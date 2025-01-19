using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] Transform targetLocation;
    [SerializeField] Vector2 target;
    [SerializeField] float step;
    public bool m;
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
         target=rb.transform.position;
    }

    // Update is called once per frame
    void Update(){
        rb.transform.position=Vector2.Lerp(rb.transform.position,target,step);
    }
    public void move()
    {
        target=targetLocation.position;
    }
}
