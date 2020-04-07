using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;
    [SerializeField] float spawnRangeX = 20;
    [SerializeField] float spawnPosZ = 20;
    [SerializeField] float startDelay = 2;

    void Start()
    {
        Invoke("SpawnRandomAnimal", startDelay);
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        startDelay = Random.Range(3.0f, 5.0f);
        Invoke("SpawnRandomAnimal", startDelay);
    }
}
