using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIinGame : MonoBehaviour
{
    public Text score;
    public Text scorePanel;
    float scoreMax;
    float HighScore;
    public Text HighScoreText;
    
    public GameObject PanelPerdiste;

    GameObject jugador;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        HighScore = PlayerPrefs.GetFloat("Highscore");
    }

    void Update()
    {
        if (jugador != null)
        {
            if (jugador.transform.position.y > scoreMax)
            {
                scoreMax = (jugador.transform.position.y);
            }
        }
        else
        {
            PanelPerdiste.SetActive(true);
            PlayerPrefs.SetFloat("Highscore", HighScore);
        }

        if (scoreMax > HighScore)
        {
            HighScore = scoreMax;
        }

        score.text = "Score: " + Mathf.Floor(scoreMax);
        scorePanel.text = "Your Score: " + Mathf.Floor(scoreMax);
        HighScoreText.text = "HighScore: " + Mathf.Floor(HighScore);
    }

    public void Reintentar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void VolverAlMenu()
    {
        SceneManager.LoadScene("01 Menu");
    }
}
