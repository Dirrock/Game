using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    GameObject jugador;
    BoxCollider2D boxito;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        boxito = gameObject.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (jugador != null)
        {
            if (jugador.transform.position.y < gameObject.transform.position.y)
            {
                boxito.enabled = false;
            }
            if (jugador.transform.position.y > gameObject.transform.position.y + 1f)
            {
                boxito.enabled = true;
            }

            if (jugador.transform.position.y > gameObject.transform.position.y + 8)
            {
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
