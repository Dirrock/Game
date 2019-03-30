using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollFondo : MonoBehaviour
{
    public Camera camara;
    MeshRenderer render;
    float posicionCamaraY = 0;

    void Start()
    { 
        render = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (camara.transform.position.y > posicionCamaraY)
        {
            render.material.mainTextureOffset = new Vector2(0, render.material.mainTextureOffset.y + 0.005f);
            posicionCamaraY = camara.transform.position.y;
        }
    }
}
