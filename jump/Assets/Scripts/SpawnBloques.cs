using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBloques : MonoBehaviour
{
    GameObject jugador;
    public GameObject[] bloques;

    int zonaseg = 2;
    int posicionY = 2;

    int posicionJugadorFacil = 0;
    int posicionJugadorMedio = 75;
    int posicionJugadorDificil = 150;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        while (jugador != null && jugador.transform.position.y > zonaseg - 4)
        {
            float posicionX = Random.Range(-3.6f, 3.6f);
            int indiceBloque = 0;

            if (jugador.transform.position.y >= posicionJugadorFacil)
            {
                indiceBloque = 0;
            }
            if (jugador.transform.position.y >= posicionJugadorMedio)
            {
                indiceBloque = 1;
            }
            if (jugador.transform.position.y >= posicionJugadorDificil)
            {
                indiceBloque = 2;
            }

            GameObject bloque = Instantiate(bloques[indiceBloque]);
            bloque.transform.position = new Vector2(posicionX, zonaseg + posicionY);

            zonaseg = zonaseg + 4;
        }
    }
}
