using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chain : MonoBehaviour
{
    float yScalemin = 1.297815f;
    float yScalemax = 3.0f;
    float incScale = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentScale = transform.localScale;
        Debug.Log(currentScale);
        if(Input.GetKey(KeyCode.S))
        {
            print("Running");
            if(Input.GetKeyDown(KeyCode.K))
            {
                transform.localScale += new Vector3(0,incScale,0);
            }
            if(Input.GetKeyDown(KeyCode.J))
            {
                transform.localScale -= new Vector3(0, incScale, 0);
            }
        } 
        currentScale = transform.localScale;
        if(currentScale.y > yScalemax)
        {
            float diff = currentScale.y - yScalemax;
            transform.localScale -= new Vector3(0, diff, 0);
        }
        else if(currentScale.y < yScalemin)
        {
            float diff = currentScale.y - yScalemin;
            transform.localScale -= new Vector3(0, diff, 0);
        }

    }
}
