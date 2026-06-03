using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI textoScore;
    public TextMeshProUGUI textoTimer;
    public bool gano = false;
    public void SumarPunto(int puntaje)
    {
            textoScore.text = "Puntos: " + puntaje.ToString();
            if(puntaje == 0){
                textoScore.text = "Ganaste";
                gano = true;
            }
    }

    public void UpdateTimer(float tiempoRestante)
    {       
            if(gano == false && tiempoRestante != 0)
            {
                textoTimer.text = "Tiempo: " + tiempoRestante.ToString("F1");
            }
            else if(gano == false && tiempoRestante == 0){
                textoTimer.text = "";
                textoScore.text = "Perdiste";   
            }
            else
            {
                textoTimer.text = "";
            }

    }

}
