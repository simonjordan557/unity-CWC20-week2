using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 16.0f;
    private float spawnRangeZ = 8.0f;
    private float spawnHeight = 10.0f;
    private float spawnLength = 20.0f;
    private float startDelay = 1.5f;
    private float spawnInterval = 1.5f;
    private float offsetLeft = 1.5f;
    private float offsetRight = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay + offsetLeft, spawnInterval + offsetLeft);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay + offsetRight, spawnInterval + offsetRight);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Select animal prefab from array, spawn at random position at top of screen
    void SpawnRandomAnimalTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnHeight);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);

    }

    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(-spawnLength, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPosition, Quaternion.Euler(0.0f, 90.0f, 0.0f));
    }

    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(spawnLength, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPosition, Quaternion.Euler(0.0f, -90.0f, 0.0f));
    }

}
