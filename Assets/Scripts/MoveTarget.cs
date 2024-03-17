using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    
    public Transform[] movePoints;
    private Vector3 targetPosition;
    private int currentIndex = 0;

    public float speed = 5f;

    void Start()
    {
        // Inicialmente, el punto de destino será el primer punto de movimiento
        targetPosition = movePoints[currentIndex].position;
    }

    void Update()
    {
        // Mover el objeto hacia el punto de destino
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Si el objeto ha llegado al punto de destino, seleccionar un nuevo punto de destino aleatorio
        if (transform.position == targetPosition)
        {
            // Seleccionar un índice de punto de movimiento aleatorio diferente al índice actual
            int newIndex = Random.Range(0, movePoints.Length);
            while (newIndex == currentIndex)
            {
                newIndex = Random.Range(0, movePoints.Length);
            }

            // Actualizar el índice actual y el punto de destino
            currentIndex = newIndex;
            targetPosition = movePoints[currentIndex].position;
        }
    }
}
