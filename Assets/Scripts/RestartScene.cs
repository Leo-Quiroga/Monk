﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartScene : MonoBehaviour
{
    public float retraso = 0.5f; // Cambia esto al valor deseado en segundos
    public int escenaObjetivo;

    public void CambiarEscenaConRetraso()
    {
        Time.timeScale = 1;
        // Invocar la funci�n para cambiar de escena despu�s del retraso
        Invoke("CambiarEscena", retraso);
    }

    private void CambiarEscena()
    {
        SceneManager.LoadScene(escenaObjetivo);
     
    }
}
