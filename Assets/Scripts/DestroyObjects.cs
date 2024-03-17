using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    public float delay = 5f;

    void Start()
    {
        // Llamar a la función DestroySelf después del retraso especificado
        Invoke("DestroySelf", delay);
    }

    // Función para destruir el GameObject
    void DestroySelf()
    {
        Destroy(gameObject);
    }
}
