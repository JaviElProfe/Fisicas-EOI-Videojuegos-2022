using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public float tiempoSpawn = 1;
    float tiempoUltimoSpawn;
    public float distanciaMax = 3;
    public float distanciaMin = -3;
    public float alturaEnemigo = -8;

    public GameObject Personaje;
    public GameObject EnemigoASpawnear;

    void Update() {
        if(Time.time - tiempoUltimoSpawn > tiempoSpawn) {
            tiempoUltimoSpawn = Time.time;
            Instantiate(EnemigoASpawnear, 
                new Vector3(Random.Range(distanciaMin, distanciaMax) + Personaje.transform.position.x, 
                            alturaEnemigo, 
                            Random.Range(distanciaMin, distanciaMax)  + Personaje.transform.position.z),
                new Quaternion());
        }    
    }
}
