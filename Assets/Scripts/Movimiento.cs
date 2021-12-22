using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Vector3 primerPosicion;
    public Vector3 muevoPosicion = new Vector3(0.002f, 0, 0.002f);
    public Vector3 actualPosicion;
    public float velocidad = 0.0005f;
    public Vector3 nuevaEscala = new Vector3(0.5f, 0.5f, 0.5f);
    // Start is called before the first frame update
    public void Start()
    {
        primerPosicion = new Vector3(0, 0.5f, 0);
        CambioEscala();
        CambioVelocidad();
    }

    // Update is called once per frame
    public void Update()
    {
        CambioPosicion();
    }

    public void CambioPosicion()
    {
        primerPosicion = primerPosicion + muevoPosicion;
        GetComponent<Transform>().position = primerPosicion;
        
    }

    public void CambioEscala()
    {
        GetComponent<Transform>().localScale = nuevaEscala;
    }

    public void CambioVelocidad()
    {
        muevoPosicion += muevoPosicion * velocidad;
    }
}
