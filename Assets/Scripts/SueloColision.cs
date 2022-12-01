using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SueloColision : MonoBehaviour
{
    
    //Si está activado isTrigger
    void OnTriggerEnter(Collider col) {
        Debug.Log("Ha entrado: " + col.gameObject.name);
    }


    //Si no está activo isTrigger
    //void OnCollisionEnter(Collision col)
}
