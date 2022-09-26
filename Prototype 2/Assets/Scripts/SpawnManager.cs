using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int spawnRangeX = 20;
    public float spawnInterval = 2.0f;

    private float spawnPositionZ = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnInterval, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        // get animal to spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject animalPrefab = animalPrefabs[animalIndex];

        // get spawn position
        int x = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(x, 0, spawnPositionZ);

        Instantiate(animalPrefab, spawnPosition, animalPrefab.transform.rotation);
    }
}
