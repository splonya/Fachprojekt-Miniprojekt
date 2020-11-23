using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject shot;
    public Transform enemyPosition;
    public float shootingSpeed = 1f;

    private float elapsed;

    private void Start()
    {
        elapsed = 0.5f / shootingSpeed;
    }

    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 0.5f / shootingSpeed)
        {
            elapsed %= 0.5f / shootingSpeed;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(shot, enemyPosition.position, Quaternion.identity);
    }
}
