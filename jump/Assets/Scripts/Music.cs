using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    GameObject jugador;
    AudioSource musica;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        musica = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jugador == null)
        {
            musica.Stop();
        }
    }
}
