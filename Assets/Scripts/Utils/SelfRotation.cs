﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    public float rotationSpeed = 5;

    private float angle = 0;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        angle = (angle + rotationSpeed / 10) % 360;
    }
}
