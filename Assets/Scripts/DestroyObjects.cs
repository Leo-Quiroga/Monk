using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    public float delay = 5f;

    void Start()
    {
        // Llamar a la funci�n DestroySelf despu�s del retraso especificado
        Invoke("DestroySelf", delay);
    }

    // Funci�n para destruir el GameObject
    void DestroySelf()
    {
        Destroy(gameObject);
    }
}
