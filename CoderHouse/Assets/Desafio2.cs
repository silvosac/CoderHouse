using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{


    public float vida;
    public float velocidad;
    public Vector3 direccion;

    public bool mover;
    public bool curar;
    public bool lastimar;


    // comentario para testear GIT
    // aca agrego el personaje

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mover)
        {
            ControlMovimiento();
        }

        Debug.Log(vida);

        if (curar)
        {
            CurarJugador();
        }

        if (lastimar)
        {
            LastimarJugador();
        }

    }

        void ControlMovimiento()
    {
        transform.position += direccion * velocidad *Time.deltaTime;
    }

    float CurarJugador()
    {
            vida += 1 * Time.deltaTime; // suma una unidad de vida por segundo
            return vida;
    }

    float LastimarJugador()
    {
        vida--; // le quita 1 unidad de vida por frame
        return vida;
    }
}
