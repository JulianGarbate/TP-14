using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI textoScore;
    public TextMeshProUGUI textoTimer;

    public void SumarPunto(int puntaje)
    {
            textoScore.text = "Puntos: " + puntaje.ToString();
    }

    public void UpdateTimer(float tiempoRestante)
    {        
            textoTimer.text = "Tiempo: " + tiempoRestante.ToString("F1");
    }
}
