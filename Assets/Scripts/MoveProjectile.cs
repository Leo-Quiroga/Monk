using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public float speed = 20f;
    public Transform playerTransform;
    public Vector3 shootDirection;

    void Start()
    {
        // Buscar el GameObject con la etiqueta "Player" y obtener su transform
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        if (playerTransform == null)
        {
            Debug.LogError("No se encontró ningún objeto con la etiqueta 'Player'");
        }
        else
        {
            // Calcular la dirección en la que el jugador está mirando
            shootDirection = playerTransform.forward;
        }
    }

    void Update()
    {
        // Mover el objeto en la dirección en la que el jugador está mirando pero en dirección opuesta
        transform.Translate(shootDirection * Time.deltaTime * speed, Space.World);
    }
}


