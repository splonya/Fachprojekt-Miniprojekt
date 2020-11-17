using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject shot;
    public Transform enemyPosition;

    private float elapsed = 0.5f;
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 0.5f)
        {
            elapsed %= 0.5f;
            Shoot();
        }
    }

    void Shoot()
    {
        Debug.Log(shot.name);
        Instantiate(shot, enemyPosition.position, Quaternion.identity);
    }
}
