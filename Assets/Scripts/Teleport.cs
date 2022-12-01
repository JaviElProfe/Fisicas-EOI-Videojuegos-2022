using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    Vector3 miPosicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        miPosicionInicial = gameObject.transform.position;    
    }

    void OnTriggerEnter(Collider col) {
        Debug.Log("He entrado en: " + col.gameObject.name);
        gameObject.transform.position = miPosicionInicial;
    }

    void OnTriggerExit(Collider col) {
        Debug.Log("He salido de: " + col.gameObject.name);
    }
}
