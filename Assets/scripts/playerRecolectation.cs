using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRecolectation : MonoBehaviour
{
    public int score = 2;
    private UiManager uiManager;
    private gameManager gManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UiManager>();
        gManager = FindObjectOfType<gameManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Agarable"))
        {
            score--; 
            uiManager.SumarPunto(score);
            Destroy(col.gameObject);

            if (score <= 0)
            {
                if (gManager != null) gManager.FinalizarJuegoGanado();
                if (uiManager != null) uiManager.MostrarPantallaWin();
                
                Time.timeScale = 0f;
            }
        }
    }
}