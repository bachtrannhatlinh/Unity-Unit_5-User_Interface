using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObjectsPrefabs;
    private float xSpawnRange = 25.0f;
    private float zSpawnRange = 25.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, startDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int indexObjects = Random.Range(0, ObjectsPrefabs.Length);
        Vector3 spawnpos = new Vector3 (Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnRange);
        Instantiate(ObjectsPrefabs[indexObjects], spawnpos, ObjectsPrefabs[indexObjects].transform.rotation);
    }
}
