using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject playerObject;
    private Transform playerTransform;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerTransform = playerObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D obstacle)
    {
        if(obstacle.CompareTag("Player"))
        {
            var player = playerObject.GetComponent<Player>();
            player.health--;
            Destroy(gameObject);
        }
        
        if (obstacle.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
