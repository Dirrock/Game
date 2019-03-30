using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public GameObject PanelAyuda;
    public GameObject PanelFondo;
    Image fondito;

    private void Start()
    {
        fondito = PanelFondo.GetComponent<Image>();
    }

    private void Update()
    {
        fondito.material.mainTextureOffset = new Vector2(0, fondito.material.mainTextureOffset.y + 0.005f);
    }

    public void Jugar()
    {
        if (PanelAyuda.activeInHierarchy == false)
        {
            SceneManager.LoadScene("02 InGame");
        }
    }
    public void Ayuda()
    {
        PanelAyuda.SetActive(true);
    }
    public void CerrarAyuda()
    {
        PanelAyuda.SetActive(false);
    }
}
