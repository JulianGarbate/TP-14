using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class gameManager : MonoBehaviour
{ 
    public float timer = 60.0f;
    private UiManager uiManager; 
    private bool juegoTerminado = false;

    void Awake()
    {
        Time.timeScale = 1f;
        uiManager = FindObjectOfType<UiManager>();
    }

    void Update()
    {
        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (juegoTerminado) return;

        if (timer > 0)
        {
            timer -= Time.deltaTime;

            if (timer < 0) timer = 0;

            if (uiManager != null)
            {
                uiManager.UpdateTimer(timer);
            }
        }
        
        if (timer <= 0 && !juegoTerminado)
        {
            TerminarJuegoPorTiempo();
        }
    }

    private void TerminarJuegoPorTiempo()
    {
        juegoTerminado = true;
        Debug.Log("¡Se terminó el tiempo!");
        
        if (uiManager != null)
        {
            uiManager.MostrarPantallaGameOver();
        }
        
        Time.timeScale = 0f; 
    }

    public void FinalizarJuegoGanado()
    {
        juegoTerminado = true;
    }
}