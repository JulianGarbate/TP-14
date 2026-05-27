using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRecolectation : MonoBehaviour
{
    public int cantidadRecolectada = 0;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("recolectable"))
        {
            cantidadRecolectada++;
            Destroy(col.gameObject);
        }
    }
}