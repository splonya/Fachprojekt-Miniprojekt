﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPursuit : MonoBehaviour
{
    public float speed;

    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
    }
}
