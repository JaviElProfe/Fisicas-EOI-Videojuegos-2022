using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public float velocidadMovimiento;
    public float fuerzaSalto;
    public GameObject camara;

    // Update is called once per frame
    void Update()
    {        
        bool andando = false;
        ///////////////////////////////////////////   MOVERNOS CON WASD  //////////////////////////////////////////////////////////////////////

        /********** HACIA DELANTE **********/
        Vector3 movimientoAdelante = new Vector3(camara.transform.forward.x, 0, camara.transform.forward.z); //No sabemos cuánto mide este vector porque va variando
        movimientoAdelante = movimientoAdelante.normalized; //Ajustamos que siempre mida 1

        if(Input.GetKey(KeyCode.W)) {
            andando = true;
            gameObject.transform.position = gameObject.transform.position + movimientoAdelante * velocidadMovimiento * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S)) {
            andando = true;
            gameObject.transform.position = gameObject.transform.position - movimientoAdelante * velocidadMovimiento * Time.deltaTime;
        }

        /********** HACIA LOS LADOS **********/
        Vector3 movimientoLateral = new Vector3(camara.transform.right.x, 0, camara.transform.right.z); //No sabemos cuánto mide este vector porque va variando
        movimientoLateral = movimientoLateral.normalized; //Ajustamos que siempre mida 1

        if(Input.GetKey(KeyCode.D)) {
            andando = true;
            gameObject.transform.position = gameObject.transform.position + movimientoLateral * velocidadMovimiento * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A)) {
            andando = true;
            gameObject.transform.position = gameObject.transform.position - movimientoLateral * velocidadMovimiento * Time.deltaTime;
        }

        if(andando && !gameObject.GetComponent<AudioSource>().isPlaying) gameObject.GetComponent<AudioSource>().Play();
        else if(!andando  && gameObject.GetComponent<AudioSource>().isPlaying) gameObject.GetComponent<AudioSource>().Pause();

        /********* SALTO ********/

        if(Input.GetKeyDown(KeyCode.Space)) {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
}
