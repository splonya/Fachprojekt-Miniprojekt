using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMovementPattern : MovableObject
{
    public Transform[] moveSpots;

    protected int currentSpotId;

    void Update()
    {
        Move();
    }

    protected abstract void Move();
}
