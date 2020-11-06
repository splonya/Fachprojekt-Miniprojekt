﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnSpots;
    public float startTimeBtwSpawns;

    private float timeBtwSpawns;

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            var randomSpot = spawnSpots[Random.Range(0, spawnSpots.Length - 1)];
            Instantiate(enemy, randomSpot.position, Quaternion.identity);
            timeBtwSpawns = 2;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
