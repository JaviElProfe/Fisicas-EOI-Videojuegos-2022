using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDisparo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destruir", 0.5f);
    }

    void Destruir() {
        Destroy(gameObject);
    }
}
