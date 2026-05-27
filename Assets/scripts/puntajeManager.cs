using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeManager : MonoBehaviour
{
    public int puntos = 0;
    public TextMeshProUGUI textoUI;

    public void SumarPunto()
    {
        puntos++;
            textoUI.text = "Puntos: "+ puntos.ToString();
    }
}
