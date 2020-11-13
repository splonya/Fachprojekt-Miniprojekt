using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclicMovement : MonoBehaviour
{
    public float speed;
    private int currentSpot;
    public Transform[] moveSpots;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = moveSpots[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (currentSpot < moveSpots.Length)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                moveSpots[currentSpot].transform.position, speed * Time.deltaTime);

        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position,
               moveSpots[0].transform.position, speed * Time.deltaTime);
            currentSpot = 0;
        }

        if ((Vector2.Distance(transform.position, moveSpots[currentSpot].position) < 0.2f))
        {
            currentSpot += 1;
        }
    }
}
