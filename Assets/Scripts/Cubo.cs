using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float velocidad;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //KeyDown al pulsar, KeyUp al soltar, Key al mantener
        {
            // Vector3.forward
            gameObject.transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Vector3.back
            gameObject.transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            // Vector3.right
            gameObject.transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Vector3.left
            gameObject.transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}
