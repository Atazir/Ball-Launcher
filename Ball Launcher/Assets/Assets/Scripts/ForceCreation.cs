using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCreation : MonoBehaviour
{
    public float thrust = 0;
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
                rb.velocity = new Vector3(0, 0, 0);
                rb.angularVelocity = Vector3.zero;
            }
            else
            {
                GetComponent<Rigidbody>().useGravity = true;
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            thrust = thrust + 5;
            if(thrust >= 50)
            {
                Debug.Log("Charged");
            }
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.AddForce(transform.forward * thrust);
        }
    }
}
