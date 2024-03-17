using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        //genera un número aleatorio en un rango (Inicio del rango, tope del rango)
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, Random.Range(-spawnPosZ, spawnPosZ));

        //instancia un prefab (nombre del prefab a instanciar, position, rotation)
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
