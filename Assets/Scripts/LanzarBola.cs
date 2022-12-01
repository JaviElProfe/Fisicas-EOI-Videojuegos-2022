using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarBola : MonoBehaviour
{
    Rigidbody rb;
    public float fuerza;

    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            rb.useGravity = true;
            rb.AddForce(new Vector3(0, .4f, 1) * fuerza, ForceMode.Impulse);
        }
    }
}
