using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    float contador = 1;

    public Camera camara;

    void Update()
    {
        contador = contador - Time.deltaTime;

        if (contador <= 0)
        {
            if (gameObject.transform.position.y <= camara.transform.position.y)
            {
                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.05f);
            }
            contador = 1;
        }
    }
}
