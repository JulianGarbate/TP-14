using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRecolectation : MonoBehaviour
{
    public int score = 2;
    private UiManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UiManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Agarable"))
        {
            score--; 
            uiManager.SumarPunto(score);
            Destroy(col.gameObject);
        }
    }
}