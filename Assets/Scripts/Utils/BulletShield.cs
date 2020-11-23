using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShield : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D obstacle)
    {
        if (obstacle.CompareTag("Bullet"))
        {
            Destroy(obstacle.gameObject);
        }
    }
}
