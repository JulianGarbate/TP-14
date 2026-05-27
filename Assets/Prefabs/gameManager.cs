using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60.0f;
    private UiManager uiManager; 

    void Awake()
    {
        uiManager = FindObjectOfType<UiManager>();
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

            if (timer < 0) timer = 0    ;

            if (uiManager != null)
            {
                uiManager.UpdateTimer(timer);
            }
        }
        else
        {
            Debug.Log("¡Se terminó el tiempo!");
        }
    }
}