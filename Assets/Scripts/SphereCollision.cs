using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{

    //Start, Update, OnEnable, OnDisable, OnDestroy

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Cube") {
            Destroy(gameObject);
        }
    }

    void OnEnable() {
        Debug.Log("Ya estoy");
    }

    void Start() {
        Debug.Log("Hola...");
    }

    void Update() {
        Debug.Log("Aquí sigo.");
    }

    void OnDisable() {
        Debug.Log("¡Ahora vengo!");
    }
    

    void OnDestroy() {
        Debug.Log("¡ADIOSSS!");
    }

}
