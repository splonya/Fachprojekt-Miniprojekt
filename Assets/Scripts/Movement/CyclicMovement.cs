using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclicMovement : BaseMovementPattern
{
    void Start()
    {
        transform.position = moveSpots[0].transform.position;
    }

    protected override void Move()
    {
        if (currentSpotId < moveSpots.Length)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                moveSpots[currentSpotId].transform.position, speed * Time.deltaTime);

        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position,
               moveSpots[0].transform.position, speed * Time.deltaTime);
            currentSpotId = 0;
        }

        if ((Vector2.Distance(transform.position, moveSpots[currentSpotId].position) < 0.2f))
        {
            currentSpotId++;
        }
    }
}
