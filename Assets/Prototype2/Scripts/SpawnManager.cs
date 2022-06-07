using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] animalPrefabs;

    private float startDelay = 5f;

    private float spawnInterval = 1f;

    //Animals Random Spawn Location on X Coordinat
    private float spawnXLocation = 20f;

    //Animals Random Spawn Location on Z Coordinat
    private float spawnZLocation = 10f;

    private float spawnOffset = 10f;

    private void Start()
    {
        InvokeRepeating("SpawnAnimals", startDelay, spawnInterval*Random.Range(1.5f,5f));
    }
    
    void Update()
    {
        
    }

    private void SpawnAnimals()
    {
        //Animals Spawn Positions
        Vector3 spawnPos = new Vector3(Random.Range(-spawnXLocation, spawnXLocation), 0, spawnZLocation + spawnOffset);
        Vector3 spawnLeftPos = new Vector3(-spawnXLocation -spawnOffset, 0, Random.Range(0, spawnZLocation));
        Vector3 spawnRightPos = new Vector3(spawnXLocation +spawnOffset, 0, Random.Range(0, spawnZLocation));
        
        //To Choose an Animals Randomly From The Animal Prefabs Array
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Spawn Animals
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], spawnLeftPos, Quaternion.Euler(0,90,0));
        Instantiate(animalPrefabs[animalIndex], spawnRightPos, Quaternion.Euler(0, -90, 0));


    }
}
