using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCreation : MonoBehaviour
{
    private Rigidbody rb;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb.useGravity == true)
            {
                rb.useGravity = false;
                //rb.velocity = new Vector3(0, 0, 0);
                print("space detected");
            }
            else
            {
                GetComponent<Rigidbody>().useGravity = true;
            }
        }

    }
}
