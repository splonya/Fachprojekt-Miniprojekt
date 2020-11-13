using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed;
    private int randomSpot;
    public Transform[] moveSpots;



    //private float waitTime;
    //public float startWaitTime;


    // Start is called before the first frame update
    void Start()
    {
        // waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            randomSpot = Random.Range(0, moveSpots.Length);
        }
    }
}
