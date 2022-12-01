using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
// using UnityEngine.UI;

public class MovimientoCamara : MonoBehaviour
{
    public float velocidadRotacion;
    public float fuerzaDisparo;
    public ParticleSystem explosionDisparo;
    public AudioSource sonidoDisparo;
    bool disparo;
    //public Text textoScore, textoShots;
    public TextMeshProUGUI textoScore, textoShots;
    int score, shots;
    const int puntuacionAcierto = 100, puntuacionFallo = -75;

    
    // Update is called once per frame
    void Update()
    {
        ///////////////////////////////////////////   GIRAR CAMARA CON RATON Y DISPARAR  //////////////////////////////////////////////////////////////////////

        if(Input.GetMouseButton(1)) { //BOTON DER DEL RATON
            float x = Input.GetAxis("Mouse X"); //COGEMOS MOVIMIENTO MOUSE EN X
            float y = Input.GetAxis("Mouse Y"); //COGEMOS MOVIMIENTO MOUSE EN Y

            /* EJE Y DEL MUNDO "Vector3.* indica mundo"*/
            gameObject.transform.RotateAround(gameObject.transform.position, Vector3.up  , x * velocidadRotacion * Time.deltaTime);

            /* EJE X DE LA CAMARA "gameObject.transform.* indica local" */
            gameObject.transform.RotateAround(gameObject.transform.position, -gameObject.transform.right, y * velocidadRotacion * Time.deltaTime);
        }

        if(Input.GetMouseButtonDown(0)) { //BOTON IZQ DEL RATON
            disparo = true;
            sonidoDisparo.Play();
        }

    }

    void FixedUpdate() {
        RaycastHit hit;
        if(disparo) {
            shots = shots+1; //shots++;
            disparo = false;
            if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 1000, LayerMask.GetMask("Disparables"))) {
                Debug.Log("Objetivo localizado!: " + hit.collider.gameObject.name);
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(gameObject.transform.forward * fuerzaDisparo, hit.point, ForceMode.Impulse);
                Instantiate(explosionDisparo, hit.point, Quaternion.Euler(0,0,0));
                hit.collider.gameObject.GetComponent<AudioSource>()?.Play();
                score = score + puntuacionAcierto;
                Destroy(hit.collider.gameObject);
            } else {
                score = score + puntuacionFallo;
                if(score < 0) score = 0;
            }
            textoShots.text = "Shots: " + shots;
            textoScore.text = "Score: " + score;
        }
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(gameObject.transform.position, gameObject.transform.forward * 20);
        Gizmos.DrawWireSphere(gameObject.transform.position + (gameObject.transform.forward*20), gameObject.transform.lossyScale.x);
    }

}
