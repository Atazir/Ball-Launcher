using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCreation : MonoBehaviour
{

    //public Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("space") /*&& this.GetComponent<Rigidbody>().useGravity == true*/)
        {
            this.GetComponent<Rigidbody>().useGravity = false;
            print("space detected");
        }
        else
        {
            this.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
