using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI textoScore;
    public TextMeshProUGUI textoTimer;

    public GameObject panelWin;
    public GameObject panelGameOver;

    public void SumarPunto(int puntaje)
    {
        textoScore.text = "Puntos: " + puntaje.ToString();
    }

    public void UpdateTimer(float tiempoRestante)
    { 
        textoTimer.text = "Tiempo: " + tiempoRestante.ToString("F1");
    }

    public void MostrarPantallaWin()
    {
        if (panelWin != null)
        {
            panelWin.SetActive(true);
        }
    }

    public void MostrarPantallaGameOver()
    {
        if (panelGameOver != null)
        {
            panelGameOver.SetActive(true);
        }
    }
}