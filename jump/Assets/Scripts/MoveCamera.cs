using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    GameObject jugador;
    float posicionCamaraY;
    public float limiteY;


    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, posicionCamaraY, gameObject.transform.position.z);

        limiteY = limiteY + 0.03f * Time.deltaTime;

        if (jugador != null && jugador.transform.position.y - limiteY > posicionCamaraY)
        {
            posicionCamaraY = jugador.transform.position.y - limiteY;
        }

        if (limiteY >= 4)
        {
            limiteY = 4;
        }

    }
}
