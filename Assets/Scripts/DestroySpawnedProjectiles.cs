using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpawnedProjectiles : MonoBehaviour
{
    private void OnDestroy()
    {
        var projectiles = GameObject.FindGameObjectsWithTag("EnemyBullet");
        Debug.Log(projectiles.Length);
        for (int i = 0; i < projectiles.Length; i++)
        {
            Destroy(projectiles[i]);
        }
    }
}
