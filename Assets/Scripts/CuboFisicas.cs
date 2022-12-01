using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboFisicas : MonoBehaviour
{
    public float fuerza;
    Rigidbody rb;

    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        //ForceMode.Force
        //ForceMode.Acceleration
        //ForceMode.Impulse
        //ForceMode.VelocityChange

        if (Input.GetKey(KeyCode.W)) //KeyDown al pulsar, KeyUp al soltar, Key al mantener
        {
            // Vector3.forward
            rb.AddForce(Vector3.forward * fuerza, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Vector3.back
            rb.AddForce(Vector3.back  * fuerza, ForceMode.Force);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            // Vector3.right
            rb.AddForce(Vector3.right  * fuerza, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Vector3.left
            rb.AddForce(Vector3.left  * fuerza, ForceMode.Force);
        }
    }
}
