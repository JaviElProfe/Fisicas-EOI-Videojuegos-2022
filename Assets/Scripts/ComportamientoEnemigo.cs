using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoEnemigo : MonoBehaviour
{
    GameObject camara;
    public float velocidad;

    void Start() {
        camara = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(camara.transform.position);
        gameObject.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * velocidad * Time.deltaTime;
    }
}
