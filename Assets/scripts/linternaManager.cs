using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linternaManager : MonoBehaviour
{
    public Light linterna;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            linterna.enabled = !linterna.enabled;
        }
    }
}
