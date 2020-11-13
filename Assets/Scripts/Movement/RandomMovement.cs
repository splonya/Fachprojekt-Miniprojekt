using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : BaseMovementPattern
{
    void Start()
    {
        currentSpotId = Random.Range(0, moveSpots.Length);
    }

    protected override void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[currentSpotId].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[currentSpotId].position) < 0.2f)
        {
            currentSpotId = Random.Range(0, moveSpots.Length);
        }
    }
}
